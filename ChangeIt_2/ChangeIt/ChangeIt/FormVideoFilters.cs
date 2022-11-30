using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChangeIt.ImageManipulation;

namespace ChangeIt
{
    public partial class FormVideoFilters : Form
    {
        Bitmap newFile;
        Bitmap originalFile;
        VideoCapture videoCapture;
        bool isPlaying = false;
        int activeFilter = -1;
        int totalFrames;
        int currentFrameNumber;
        int fps;
        String fileName;
        Mat currentFrame;

        ImageManipulation modifyRGB = new ImageManipulation();
        FileOperations getFile = new FileOperations();

        public string[] FilterList =
        {
            "Sepia", "Escala de Grises", "Invertir", "Binario con Umbral", "Aislar Canal Rojo", "Aislar Canal Verde", "Aislar Canal Azul", "México"
        };

        public FormVideoFilters()
        {
            InitializeComponent();
            LoadFilterList();

            modifyRGB.ImageFinished += OnImageFinished;
            modifyRGB.HistogramFinished += OnHistogramFinished;
        }

        private void LoadFilterList()
        {
            foreach (var filter in FilterList)
                cbSelectedFilter.Items.Add(filter);
        }

        public void DisplayImage(Bitmap b, int window)
        {
            if (window == 1)
            {
                pBOriginal.Image = b;
            }
            else if (window == 2)
            {
                pbEdited.Image = b;
            }
            else
            {
                pBOriginal.Image = b;
                pbEdited.Image = b;
            }
        }

        public void LoadVideoIntoPictureBox()
        {
            fileName = getFile.OpenVideoFile();

            if(fileName != null)
            {
                videoCapture = new VideoCapture(fileName);
                totalFrames = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                fps = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                currentFrame = new Mat();
                currentFrameNumber = 0;
                cbSelectedFilter.Enabled = true;
                btnResetVideo.Enabled = true;
                btnPlayStop.BackColor = Color.FromArgb(210, 150, 57);
                btnPlayStop.IconColor = Color.FromArgb(10, 13, 39);
                btnPlayStop.IconChar = FontAwesome.Sharp.IconChar.Pause;
                PlayVideo();
            }
        }

        private async void PlayVideo()
        {
            if (videoCapture != null)
            {
                isPlaying = true;
                btnPlayStop.Enabled = true;
                try
                {
                    btnPlayStop.BackColor = Color.FromArgb(210, 150, 57);
                    btnPlayStop.IconColor = Color.FromArgb(10, 13, 39);
                    btnPlayStop.IconChar = FontAwesome.Sharp.IconChar.Pause;

                    while (isPlaying && currentFrameNumber < totalFrames)
                    {

                        chartHistOriginal.Series["Red"].Points.Clear();
                        chartHistOriginal.Series["Green"].Points.Clear();
                        chartHistOriginal.Series["Blue"].Points.Clear();

                        chartHistEdited.Series["Red"].Points.Clear();
                        chartHistEdited.Series["Green"].Points.Clear();
                        chartHistEdited.Series["Blue"].Points.Clear();

                        videoCapture.Read(currentFrame);

                        newFile = currentFrame.ToBitmap();

                        originalFile = new Bitmap(newFile);

                        DisplayImage(originalFile, 1);
                        DisplayImage(newFile, 2);

                        modifyRGB.getLockBitsHistogram(originalFile, 'r', 1);
                        modifyRGB.getLockBitsHistogram(originalFile, 'b', 1);
                        modifyRGB.getLockBitsHistogram(originalFile, 'g', 1);

                        if(activeFilter >= 0)
                            modifyRGB.ManipulateLockBits(newFile, activeFilter + 1, tbSliderControl.Value);
                        

                        currentFrameNumber++;

                        await Task.Delay(1000 / fps);

                    }
                    
                    btnPlayStop.BackColor = Color.FromArgb(10, 13, 39);
                    btnPlayStop.IconColor = Color.FromArgb(83, 182, 156);
                    btnPlayStop.IconChar = FontAwesome.Sharp.IconChar.Play;

                    if(currentFrameNumber >= totalFrames)
                    {
                        currentFrameNumber = 0;
                        isPlaying = false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        public void DisplayHistogram(Dictionary<int, int> d, int window, string channel)
        {
            if (window == 1)
            {
                chartHistOriginal.Series[channel].Points.Clear();
                foreach (int key in d.Keys)
                {
                    chartHistOriginal.Series[channel].Points.AddXY(key, d[key]);
                }
            }
            else if (window == 2)
            {
                chartHistEdited.Series[channel].Points.Clear();
                foreach (int key in d.Keys)
                {
                    chartHistEdited.Series[channel].Points.AddXY(key, d[key]);
                }
            }
            else
            {
                chartHistOriginal.Series[channel].Points.Clear();
                chartHistEdited.Series[channel].Points.Clear();
                foreach (int key in d.Keys)
                {
                    chartHistOriginal.Series[channel].Points.AddXY(key, d[key]);
                    chartHistEdited.Series[channel].Points.AddXY(key, d[key]);

                }
            }
        }

        void OnImageFinished(object sender, ImageEventArgs e)
        {
            DisplayImage(e.bmap, 2);
            modifyRGB.getLockBitsHistogram(e.bmap, 'r', 2);
            modifyRGB.getLockBitsHistogram(e.bmap, 'g', 2);
            modifyRGB.getLockBitsHistogram(e.bmap, 'b', 2);


            //MessageBox.Show("Filtro aplicado");

        }

        void OnHistogramFinished(object sender, HistogramEventArgs e)
        {
            switch (e.channel)
            {
                case 'r':
                case 'R':
                    DisplayHistogram(e.histo, e.display, "Red");
                    break;

                case 'g':
                case 'G':
                    DisplayHistogram(e.histo, e.display, "Green");
                    break;

                case 'b':
                case 'B':
                    DisplayHistogram(e.histo, e.display, "Blue");
                    break;
            }
        }


        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            LoadVideoIntoPictureBox();
            if (fileName != null)
            {              

                cbSelectedFilter.Enabled = true;
                btnResetVideo.Enabled = true;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            activeFilter = cbSelectedFilter.SelectedIndex + 1;
        }

        private void cbSelectedFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeFilter = cbSelectedFilter.SelectedIndex;

            if (cbSelectedFilter.SelectedIndex == 3)
            {
                tbSliderControl.Enabled = true;
                lbControlSliderDes.Text = "Umbral";
            }
            else
            {
                tbSliderControl.Enabled = false;
                lbControlSliderDes.Text = "";
            }
        }

        private void tbSliderControl_ValueChanged(object sender, EventArgs e)
        {
            lbControlSliderVal.Text = tbSliderControl.Value.ToString();
        }

        private void btnResetVideo_Click(object sender, EventArgs e)
        {
            activeFilter = -1;
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                btnPlayStop.BackColor = Color.FromArgb(210, 150, 57);
                btnPlayStop.IconColor = Color.FromArgb(10, 13, 39);
                btnPlayStop.IconChar = FontAwesome.Sharp.IconChar.Pause;
                isPlaying = false;
            }
            else
            {
                btnPlayStop.BackColor = Color.FromArgb(10, 13, 39);
                btnPlayStop.IconColor = Color.FromArgb(83, 182, 156);
                btnPlayStop.IconChar = FontAwesome.Sharp.IconChar.Play;

                if(currentFrameNumber == 0)
                {
                    videoCapture = new VideoCapture(fileName);
                    totalFrames = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                    fps = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                    currentFrame = new Mat();
                }
                PlayVideo();
            }
        }
    }
}
