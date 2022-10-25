using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChangeIt
{
    class ImageManipulation
    {
       
        public class ImageEventArgs: EventArgs
        {
            public Bitmap bmap { get; set; }
        }

        //Manipulate method (bitmap)
        public void Manipulate(Bitmap bmap, int selectedFilter)
        {
            Color theColor = new Color();

            for(int i = 0; i < bmap.Width; i++)
            {
                for(int j = 0; j < bmap.Height; j++)
                {
                    //Get the color of the pixel at (i,j)
                    theColor = bmap.GetPixel(i, j);

                    Color theNewColor;

                    //Change the color of the pixel
                    switch (selectedFilter)
                    {
                        case 1:
                            {
                                theNewColor = turnSepia(theColor);
                                break;
                            }

                        default:
                            {
                                theNewColor = theColor;
                                break;
                            }
                    }

                    bmap.SetPixel(i, j, theNewColor);
                }
            }

            OnImageFinished(bmap);
        }

        //Filter methods
        public Color turnSepia(Color theColor)
        {

            int tr, tg, tb, a, r, g, b;

            //extract pixel components
            a = theColor.A;
            r = theColor.R;
            g = theColor.G;
            b = theColor.B;

            //Calculate temp value
            tr = (int)(r*0.393 + g* 0.769 + b* 0.189);
            tg = (int)(r*0.349 + g* 0.686 + b* 0.168);
            tb = (int)(r*0.272 + g* 0.534 + b* 0.131);

            //set new RGB value
            if(tr > 255)
            {
                r = 255;
            }
            else
            {
                r = tr;
            }

            if (tg > 255)
            {
                g = 255;
            }
            else
            {
                g = tg;
            }

            if(tb > 255)
            {
                b = 255;
            }
            else
            {
                b = tb;
            }            

            return Color.FromArgb(a, r, g, b);
        }


        //Define the Event Handler Delegate
        public event EventHandler<ImageEventArgs> ImageFinished;

        //Add Event method
        protected virtual void OnImageFinished(Bitmap bmap)
        {
            ImageFinished?.Invoke(this, new ImageEventArgs() { bmap = bmap });
        }

    }
}
