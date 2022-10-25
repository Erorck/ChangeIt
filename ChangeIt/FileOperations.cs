using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChangeIt
{
    class FileOperations
    {
        Bitmap newImage;

        //Open file and make a new bitmap

        public Bitmap OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C:\\Images";
            ofd.Filter = "images| *.jpg; *.png; *.bmp";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                newImage = new Bitmap(Image.FromFile(ofd.FileName));
            }

            return newImage;
        }
    }
}
