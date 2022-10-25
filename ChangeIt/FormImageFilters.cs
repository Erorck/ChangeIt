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

        ImageManipulation modifyRGB = new ImageManipulation();
        FileOperations getFile = new FileOperations();

        public string[] FilterList =
        {
            "Sepia", "Escala de Grises", "Invertir", "Espejo", "Desenfoque"
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
                cbSelectedFilter.Enabled = true;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            modifyRGB.Manipulate(newFile, cbSelectedFilter.SelectedIndex + 1);
        }

        private void btnResetImage_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {

        }

        private void cbSelectedFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApplyFilter.Enabled = true;
        }
    }
}
