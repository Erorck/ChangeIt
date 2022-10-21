using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace ChangeIt
{
    public partial class FormCameraUtilities : Form
    {
        #region Variables
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice selectedDevice;
        private int newSelectedIndex = -1;
        private int oldSelectedIndex = -1;
        private bool enableSaveImage = false;

        List<Image<Gray, Byte>> trainedFaces = new List<Image<Gray, byte>>();
        List<int> personLabels = new List<int>();
        private static bool isTrained = false;


        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        #endregion

        public FormCameraUtilities()
        {
            InitializeComponent();
        }

        private void FormCameraUtilities_Load(object sender, EventArgs e)
        {
            LoadDevicesList();
            btnTurnOn.Enabled = false;
        }


        #region Funciones Camara
        //Selected Device Changed
        private void cbSelectedDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTurnOn.Enabled = true;
            newSelectedIndex = cbSelectedDevice.SelectedIndex;
        }


        public void LoadDevicesList()
        {
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(myDevices.Count > 0)
            {
                for(int i=0; i<myDevices.Count; i++)
                {
                    cbSelectedDevice.Items.Add(myDevices[i].Name.ToString());
                }
                //cbSelectedDevice.Text = myDevices[0].ToString();
            }
            else
            {
            }            
        }


        public void CloseCurrentDevice()
        {
            if (selectedDevice != null && selectedDevice.IsRunning)
            {
                selectedDevice.SignalToStop();
                selectedDevice = null;
                pBVideoPreview.Image = null;
            }
        }


        private void BtnTurnOn_Click(object sender, EventArgs e)
        {
            CloseCurrentDevice();
            ResetDetectionControls();
            noCameraIcon.BringToFront();
            if (oldSelectedIndex != newSelectedIndex)
            {

                int i = cbSelectedDevice.SelectedIndex;
                string deviceName = myDevices[i].MonikerString;

                //Video Capture
                selectedDevice = new VideoCaptureDevice(deviceName);

                selectedDevice.NewFrame +=  new NewFrameEventHandler(Capturing);
                btnAddPerson.Enabled = true;

                selectedDevice.Start();
                noCameraIcon.SendToBack();
                oldSelectedIndex = newSelectedIndex;
            }
            else
            {
                oldSelectedIndex = -1;
            }
        }


        private void Capturing(object sender, NewFrameEventArgs eventArgs)
        {
            //Clone the frame
            Bitmap currentFrame = (Bitmap)eventArgs.Frame.Clone();



            #region Detección Facial
            //Convert from Bgr to Image
            Mat grayImage = new Mat();
            Image<Bgr, byte> currentFrameCV = currentFrame.ToImage<Bgr, byte>(); //Convert Bitmpap to Image CV
            CvInvoke.CvtColor(currentFrameCV, grayImage, ColorConversion.Bgr2Gray);

            //Enhance the image to get a better result
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            ThreadSafe(() =>
            {
                if (selectedDevice != null && selectedDevice.IsRunning)
                    UpdateDetectionControls(faces.Length); //Código que modifica controles creados en el hilo principal
                else
                    ResetDetectionControls();
            }, this);  //this si estas en la clase del formulario principal

            //If faces detected
            if (faces.Length > 0)
            {

                foreach(var face in faces)
                {
                    //Draw square around each face
                    CvInvoke.Rectangle(currentFrameCV, face, new Bgr(Color.Red).MCvScalar, 2);

                    //Add person
                    //Assign the face to the picture Box face
                    Image<Bgr, Byte> resultImage = currentFrameCV.Convert<Bgr, Byte>();
                    resultImage.ROI = face;
                    pbDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbDetected.Image = resultImage.ToBitmap();

                    if (enableSaveImage)
                    {
                        //Create directory if not exists
                        string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);


                        //Save 10 images with delay a second for each image
                        ThreadSafe(() =>
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                //resize the image to save it
                                resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + tbPersonName.Text + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                Thread.Sleep(1000);
                            }                        
                        }, this);
                    }
                    enableSaveImage = false;
                }
            }
            #endregion



            //Show final Image
            if (selectedDevice != null && selectedDevice.IsRunning)
                pBVideoPreview.Image = currentFrameCV.ToBitmap();
            else
            {
                pBVideoPreview.Image = null;
                pbDetected.Image = null;
            }
        }
        #endregion

        private bool TrainImagesFromDir()
        {
            int imagesCount = 0;
            double threshold = 7000;
            trainedFaces.Clear();
            personLabels.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedFaces";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, byte>(file);
                    trainedFaces.Add(trainedImage);
                    personLabels.Add(imagesCount);

                    imagesCount++;
                }

                EigenFaceRecognizer recognizer = new EigenFaceRecognizer(imagesCount, threshold);
                recognizer.Train(trainedFaces.ToArray(), personLabels.ToArray());

                isTrained = true;
                Debug.WriteLine(imagesCount);
                Debug.WriteLine(isTrained);
                return true;
            }
            catch(Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images" + ex.Message);
                return false;
            }
        }

        //BackgroundWorker
        private void ThreadSafe(Action callback, Form form)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.RunWorkerCompleted += (obj, e) =>
            {
                if (form.InvokeRequired)
                    form.Invoke(callback);
                else
                    callback();
            };
            worker.RunWorkerAsync();
        }

        private void UpdateDetectionControls(int faces)
        {
            lblDetectedUsers.Text = faces.ToString() + " detected";
        }

        private void ResetDetectionControls()
        {
            lblDetectedUsers.Text = "No video entry";
            lblDetectedMovingUsers.Text = "No video entry";
            btnAddPerson.Enabled = false;
        }

        private void FormCameraUtilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCurrentDevice();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnAddPerson.Enabled = false;
            enableSaveImage = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnAddPerson.Enabled = true;
            enableSaveImage = false;
        }
    }
}
