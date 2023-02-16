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
using Emgu.CV.Util;
using System.Linq;

namespace ChangeIt
{
    public partial class FormCameraUtilities : Form
    {
        #region Variables
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice selectedDevice;
        private int newSelectedIndex = -1;
        private int oldSelectedIndex = -1;
        private static bool enableSaveImage = false;
        private static bool enableDetectFaces = false;

        List<Mat> trainedFaces = new List<Mat>();
        List<int> personLabels = new List<int>();
        List<string> PersonsNames = new List<string>();
        EigenFaceRecognizer recognizer;
        private static bool isTrained = false;
        private static bool isClosing = false;

        static string myFileName = Path.Combine(System.Windows.Forms.Application.StartupPath, "haarcascade_frontalface_alt.xml");

        CascadeClassifier faceCascadeClassifier = new CascadeClassifier(myFileName);
        #endregion

        public FormCameraUtilities()
        {
            InitializeComponent();
        }

        private void FormCameraUtilities_Load(object sender, EventArgs e)
        {
            LoadDevicesList();
            btnTurnOn.Enabled = false;
            isClosing = false;
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
            if (myDevices.Count > 0)
            {
                for (int i = 0; i < myDevices.Count; i++)
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

                selectedDevice.NewFrame += new NewFrameEventHandler(Capturing);
                btnDetectFaces.Enabled = true;

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
            if (isClosing)
                return;

            //Clone the frame
            Bitmap currentFrame = (Bitmap)eventArgs.Frame.Clone();

            #region Detección Facial
            //Convert from Bgr to Image
            Mat grayImage = new Mat();
            Image<Bgr, byte> currentFrameCV = currentFrame.ToImage<Bgr, byte>(); //Convert Bitmpap to Image CV
            CvInvoke.CvtColor(currentFrameCV, grayImage, ColorConversion.Bgr2Gray);

            //Enhance the image to get a better result
            //CvInvoke.EqualizeHist(grayImage, grayImage);

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

                foreach (var face in faces)
                {
                    //Draw square around each face
                    CvInvoke.Rectangle(currentFrameCV, face, new Bgr(Color.Red).MCvScalar, 2);

                    //Add person
                    //Assign the face to the picture Box face
                    Image<Bgr, Byte> resultImage = currentFrameCV.Convert<Bgr, Byte>();
                    resultImage.ROI = face;
                    if (enableDetectFaces)
                    {
                        pbDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbDetected.Image = resultImage.ToBitmap();
                    }

                    if (enableSaveImage)
                    {
                        //Create directory if not exists
                        string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);


                        //Save image
                        ThreadSafe(() =>
                        {                       
                                //resize the image to save it
                                resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + tbPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                Thread.Sleep(1000);
                                tbPersonName.Text = "";                            

                        }, this);

                    }
                    enableSaveImage = false;

                    // Recognize faces
                    if (isTrained)
                    {
                        Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, byte>().Resize(200, 200, Inter.Cubic);
                        //CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                        var result = recognizer.Predict(grayFaceResult);
                        if (result.Label != -1 && result.Distance < 2000)
                        {
                            CvInvoke.PutText(currentFrameCV, PersonsNames[result.Label], new Point(face.X - 1, face.Y - 2),
                                FontFace.HersheyComplex, 1.0, new Bgr(Color.Yellow).MCvScalar);
                            CvInvoke.Rectangle(currentFrameCV, face, new Bgr(Color.Green).MCvScalar, 2);
                        }
                        else //No recognozible faces found
                        {
                            CvInvoke.PutText(currentFrameCV, "Unknown", new Point(face.X - 1, face.Y - 2),
                                FontFace.HersheyComplex, 1.0, new Bgr(Color.Yellow).MCvScalar);
                        }
                    }

                    //if (resultImage != null)
                    //    resultImage.Dispose();
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

            if (currentFrameCV != null)
            {
                currentFrameCV.Dispose();
                currentFrame.Dispose();
            }
        }
        #endregion

        private bool TrainImagesFromDir()
        {
            isTrained = false;
            int imagesCount = 0;
            double threshold = 2000;
            trainedFaces.Clear();
            personLabels.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("There are no Images to Analyze, save a face");
                    return false;
                }



                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                if (files.Length <= 0)
                {
                    MessageBox.Show("There are no Images to Analyze, save a face");
                    return false;
                }


                foreach (var file in files)
                {
                    //Mat trainedImage = new Mat(file);
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);

                    //CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    trainedFaces.Add(trainedImage.Mat);
                    personLabels.Add(imagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);

                    imagesCount++;
                }

                if (trainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(imagesCount, threshold);
                    //recognizer.Train(new VectorOfMat(trainedFaces.ToArray()), new VectorOfInt(personLabels.ToArray()));
                    recognizer.Train(trainedFaces.ToArray(), personLabels.ToArray());

                    isTrained = true;
                    Debug.WriteLine(imagesCount);
                    Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }
        }

        //BackgroundWorker
        private void ThreadSafe(Action callback, Form form)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;           

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
            btnDetectFaces.Enabled = false;
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            enableDetectFaces = !enableDetectFaces;
            btnSave.Enabled = enableDetectFaces;
            //btnDetectFaces.Enabled = false;
            enableSaveImage = false;
            pbDetected.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPersonName.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un nombre para la persona");
                return;
            }

            btnSave.Enabled = true;
            //btnDetectFaces.Enabled = false;
            enableSaveImage = true;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
            //if (isTrained)
            //{
            //    btnAnalyze.Enabled = false;
            //}
        }

        private void FormCameraUtilities_FormClosing(object sender, FormClosingEventArgs e)
        {

            isClosing = true;
            CloseCurrentDevice();
            enableSaveImage = false;
            enableDetectFaces = false;
            isTrained = false;

        }

        private void FormCameraUtilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCurrentDevice();
        }
    }
}
