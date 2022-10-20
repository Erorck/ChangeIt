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

namespace ChangeIt
{
    public partial class FormCameraUtilities : Form
    {
        #region Variables
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice selectedDevice;
        private int newSelectedIndex = -1;
        private int oldSelectedIndex = -1;

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
            ResetDetectionStatistics();
            noCameraIcon.BringToFront();
            if (oldSelectedIndex != newSelectedIndex)
            {

                int i = cbSelectedDevice.SelectedIndex;
                string deviceName = myDevices[i].MonikerString;

                //Video Capture
                selectedDevice = new VideoCaptureDevice(deviceName);

                selectedDevice.NewFrame +=  new NewFrameEventHandler(Capturing);

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
            Bitmap Image = (Bitmap)eventArgs.Frame.Clone();

            //Convert from Bgr to Image
            Mat grayImage = new Mat();
            Image<Bgr, byte> imageCV = Image.ToImage<Bgr, byte>(); //Convert Bitmpap to Image CV
            CvInvoke.CvtColor(imageCV, grayImage, ColorConversion.Bgr2Gray);

            //Enhance the image to get a better result
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            ThreadSafe(() =>
            {
                if (selectedDevice != null && selectedDevice.IsRunning)
                    UpdateDetectionStatistics(faces.Length); //Código que modifica controles creados en el hilo principal
                else
                    ResetDetectionStatistics();
            }, this);  //this si estas en la clase del formulario principal

            //If faces detected
            if (faces.Length > 0)
            {

                foreach(var face in faces)
                {
                    //Draw square around each face
                    CvInvoke.Rectangle(imageCV, face, new Bgr(Color.Red).MCvScalar, 2);
                }
            }

            //Show final Image
            if (selectedDevice != null && selectedDevice.IsRunning)
                pBVideoPreview.Image = imageCV.ToBitmap();
            else
                pBVideoPreview.Image = null;
        }
        #endregion


        //Usando BackgroundWorker
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

        private void UpdateDetectionStatistics(int faces)
        {
            lblDetectedUsers.Text = faces.ToString() + " detected";
        }

        private void ResetDetectionStatistics()
        {
            lblDetectedUsers.Text = "No video entry";
            lblDetectedMovingUsers.Text = "No video entry";
        }

        private void FormCameraUtilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCurrentDevice();
        }
              

        
    }
}
