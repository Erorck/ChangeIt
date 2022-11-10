using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
