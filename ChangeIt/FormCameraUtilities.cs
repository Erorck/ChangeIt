using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace ChangeIt
{
    public partial class FormCameraUtilities : Form
    {
        private bool connectedDevices;
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice selectedDevice;
        private int newSelectedIndex = -1;
        private int oldSelectedIndex = -1;

        public FormCameraUtilities()
        {
            InitializeComponent();
        }

        private void FormCameraUtilities_Load(object sender, EventArgs e)
        {
            LoadDevicesList();
            btnTurnOn.Enabled = false;
        }

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
                connectedDevices = true;
                for(int i=0; i<myDevices.Count; i++)
                {
                    cbSelectedDevice.Items.Add(myDevices[i].Name.ToString());
                }
                //cbSelectedDevice.Text = myDevices[0].ToString();
            }
            else
            {
                connectedDevices = false;
            }            
        }

        public void ToggleDevice()
        {
            if (selectedDevice != null)
            {
                if (selectedDevice.IsRunning)
                    selectedDevice.SignalToStop();
                else
                    selectedDevice.Start();
                       
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
            noCameraIcon.BringToFront();
            if (oldSelectedIndex != newSelectedIndex)
            {
                int i = cbSelectedDevice.SelectedIndex;
                string deviceName = myDevices[i].MonikerString;
                selectedDevice = new VideoCaptureDevice(deviceName);
                selectedDevice.NewFrame += new NewFrameEventHandler(Capturing);
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
            Bitmap Image = (Bitmap)eventArgs.Frame.Clone();
            pBVideoPreview.Image = Image;
        }

        private void FormCameraUtilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCurrentDevice();
        }

        private void pBVideoPreview_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
