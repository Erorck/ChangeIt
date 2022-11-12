using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static ChangeIt.ImageManipulation;

namespace ChangeIt
{
    public partial class FormImageFilters : Form
    {
        Bitmap newFile;
        Bitmap originalFile;

        ImageManipulation modifyRGB = new ImageManipulation();
        FileOperations getFile = new FileOperations();

        public string[] FilterList =
        {
            "Sepia", "Escala de Grises", "Invertir", "Espejo", "Binario con Umbral", "Aislar Canal Rojo", "Aislar Canal Verde", "Aislar Canal Azul"
        };

        public FormImageFilters()
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
            btnApplyFilter.Enabled = true;
            btnSaveImage.Enabled = true;
            modifyRGB.getHistogram(e.bmap, 'r', 2);
            modifyRGB.getHistogram(e.bmap, 'g', 2);
            modifyRGB.getHistogram(e.bmap, 'b', 2);
            

            MessageBox.Show("Filtro aplicado");

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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            newFile = getFile.OpenFile();
            if (newFile != null)
            {
                DisplayImage(newFile, 1);
                originalFile = new Bitmap(newFile);

                modifyRGB.getHistogram(originalFile, 'r', 1);
                modifyRGB.getHistogram(originalFile, 'b', 1);
                modifyRGB.getHistogram(originalFile, 'g', 1);
                

                chartHistEdited.Series["Red"].Points.Clear();
                chartHistEdited.Series["Green"].Points.Clear();
                chartHistEdited.Series["Blue"].Points.Clear();

                pbEdited.Image = null;

                cbSelectedFilter.Enabled = true;
                btnResetImage.Enabled = true;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            modifyRGB.Manipulate(newFile, cbSelectedFilter.SelectedIndex + 1, tbSliderControl.Value);
        }

        private void btnResetImage_Click(object sender, EventArgs e)
        {
            newFile = new Bitmap(originalFile);

            modifyRGB.getHistogram(originalFile, 'r', 3);
            modifyRGB.getHistogram(originalFile, 'b', 3);
            modifyRGB.getHistogram(originalFile, 'g', 3);           

            DisplayImage(newFile, 1);
            DisplayImage(newFile, 2);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            getFile.SaveImage((Bitmap)pbEdited.Image);
        }

        private void cbSelectedFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApplyFilter.Enabled = true;
            if (cbSelectedFilter.SelectedIndex == 4)
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
    }
}
