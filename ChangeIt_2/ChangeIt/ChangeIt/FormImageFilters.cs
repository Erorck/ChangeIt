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
        }

        private void LoadFilterList()
        {
            foreach(var filter in FilterList)
                cbSelectedFilter.Items.Add(filter);
        }

        public void DisplayImage(Bitmap b, int window)
        {
            if(window == 1)
            {
                pBOriginal.Image = b;
            }
            else if(window == 2)
            {
                pbEdited.Image = b;
            }
            else
            {
                pBOriginal.Image = b;
                pbEdited.Image = b;
            }
        }

        void OnImageFinished(object sender, ImageEventArgs e)
        {
            DisplayImage(e.bmap, 2);
            btnApplyFilter.Enabled = true;
            btnSaveImage.Enabled = true;
            MessageBox.Show("Filtro aplicado");
            HistoGram(e.bmap);
        }

        private void HistoGram(Bitmap bmp)
        {
            // Get your image in a bitmap; this is how to get it from a picturebox
            // Store the histogram in a dictionary          
            Dictionary<Color, int> histo = new Dictionary<Color, int>();
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Get pixel color 
                    Color c = bmp.GetPixel(x, y);
                    // If it exists in our 'histogram' increment the corresponding value, or add new
                    if (histo.ContainsKey(c))
                        histo[c] = histo[c] + 1;
                    else
                        histo.Add(c, 1);
                }
            }
            // This outputs the histogram in an output window
            foreach (Color key in histo.Keys)
            {
                Debug.WriteLine(key.ToString() + ": " + histo[key]);
            }
        }


        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            newFile = getFile.OpenFile();
            if(newFile != null)
            {
                DisplayImage(newFile, 1);
                originalFile = new Bitmap(newFile);
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
            if(cbSelectedFilter.SelectedIndex == 4)
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
