using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                newImage = new Bitmap(Image.FromFile(ofd.FileName));
            }

            return newImage;
        }

        public void SaveImage(Bitmap img)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:\\Images";
            sfd.Filter = "images| *.jpg; *.png; *.bmp";

            ImageFormat format = ImageFormat.Png;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string ext = Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                img.Save(sfd.FileName, format);

                MessageBox.Show("Imagen guardada exitosamente en el directorio " + sfd.FileName);

            }

        }
    }
}
