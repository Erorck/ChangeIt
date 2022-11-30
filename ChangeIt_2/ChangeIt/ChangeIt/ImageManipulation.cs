using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;

namespace ChangeIt
{
    class ImageManipulation
    {
        private static object control = new object();

        public class ImageEventArgs: EventArgs
        {
            public Bitmap bmap { get; set; }
        }

        public class HistogramEventArgs : EventArgs
        {
            public Dictionary<int, int> histo { get; set; }
            public char channel { get; set; }
            public int display { get; set; }
        }

        //Manipulate method (bitmap)
        public void Manipulate(Bitmap bmap, int selectedFilter, int extra = 127)
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

                        case 2:
                            {
                                theNewColor = turnGrayscale(theColor);
                                break;
                            }

                        case 3:
                            {
                                theNewColor = turnInverted(theColor);
                                break;
                            }

                       case 4:
                            {
                                Bitmap mBmap = mirrorImage(bmap);
                                OnImageFinished(mBmap);
                                bmap = mBmap;
                                return;
                            }

                        case 5:
                            {
                                theNewColor = turnBinary(theColor, extra);
                                break;
                            }

                        case 6:
                            {
                                theNewColor = turnOneColorChannel(theColor, 'R');
                                break;
                            }

                        case 7:
                            {
                                theNewColor = turnOneColorChannel(theColor, 'G');
                                break;
                            }

                        case 8:
                            {
                                theNewColor = turnOneColorChannel(theColor, 'B');
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

        //Faster manipulate method (bitmap)
        public void ManipulateLockBits(object bmp, int selectedFilter, int extra = 127)
        {
            Bitmap bmap = (Bitmap)bmp;

            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                //Define Variables for bytes per pixel, as ewll as Image Widht and Height
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                //Define a pointer to the first in the locked image.
                //Scan0 gets or sets the address of the first pixel data in the bitmap
                //This can also be thought of as the first scan line in the bitmap
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
                Color theNewColor;

                //Step thru each pixel in the image using pointers
                //Parallel.For executes a 'for' lopp in which iterations may run in parallel
                Parallel.For(0, heightInPixels,  y =>
                {
                    //Use the 'stride' (scanline width) property to step line by line thru the image
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for(int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        //GET each pixel color
                        int oldRed = currentLine[x + 2];
                        int oldGreen = currentLine[x + 1];
                        int oldBlue = currentLine[x];

                        Color theColor = Color.FromArgb(255, oldRed, oldGreen, oldBlue);

                        lock (control)
                        {
                            //Change the color of the pixel
                            switch (selectedFilter)
                            {
                                case 1:
                                    {
                                        theNewColor = turnSepia(theColor);
                                        break;
                                    }

                                case 2:
                                    {
                                        theNewColor = turnGrayscale(theColor);
                                        break;
                                    }

                                case 3:
                                    {
                                        theNewColor = turnInverted(theColor);
                                        break;
                                    }

                                case 4:
                                    {
                                        bmap.UnlockBits(bitmapData);
                                        Bitmap mBmap = mirrorImage(bmap);
                                        OnImageFinished(mBmap);
                                        bmap = mBmap;
                                        return;
                                    }

                                case 5:
                                    {
                                        theNewColor = turnBinary(theColor, extra);
                                        break;
                                    }

                                case 6:
                                    {
                                        theNewColor = turnOneColorChannel(theColor, 'R');
                                        break;
                                    }

                                case 7:
                                    {
                                        theNewColor = turnOneColorChannel(theColor, 'G');
                                        break;
                                    }

                                case 8:
                                    {
                                        theNewColor = turnOneColorChannel(theColor, 'B');
                                        break;
                                    }
                                case 9:
                                    {
                                        theNewColor = turnMexico(theColor);
                                        break;
                                    }

                                default:
                                    {
                                        theNewColor = theColor;
                                        break;
                                    }
                            }

                            currentLine[x] = theNewColor.B;
                            currentLine[x + 1] = theNewColor.G;
                            currentLine[x + 2] = theNewColor.R;
                        }
                        

                        //currentLine[x] = 0;
                        //currentLine[x + 1] = (byte)oldGreen;
                        //currentLine[x + 2] = (byte)oldRed;
                    }
                });

                bmap.UnlockBits(bitmapData);

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

        public Color turnGrayscale(Color theColor)
        {

            int a, r, g, b;

            //extract pixel components
            a = theColor.A;
            r = theColor.R;
            g = theColor.G;
            b = theColor.B;

            //Calculate temp value
            int avg = (int)(r + g + b)/3;


            //set new RGB value
            r = avg;
            g = avg;
            b = avg;

            return Color.FromArgb(a, r, g, b);
        }

        public Color turnInverted(Color theColor)
        {

            int ir, ig, ib, a, r, g, b;

            //extract pixel components
            a = theColor.A;
            r = theColor.R;
            g = theColor.G;
            b = theColor.B;

            //Calculate temp value
            ir = 255 - r;
            ig = 255 - g;
            ib = 255 - b;

            //set new RGB value           

            return Color.FromArgb(a, ir, ig, ib);
        }

        public Color turnMexico(Color theColor)
        {
            int a, r, g, b;

            //extract pixel components
            a = theColor.A;
            r = theColor.R;
            g = theColor.G;
            b = theColor.B;

            return Color.FromArgb(a, r, g, 0);

        }

        public Color turnBinary(Color theColor, int threshold = 127)
        {

            int a, r, g, b;

            //extract pixel components
            a = theColor.A;
            r = theColor.R;
            g = theColor.G;
            b = theColor.B;

            //Calculate temp value
            int avg = (int)(r + g + b) / 3;

            
            int newColor = 0;

            //set new RGB value
            if (avg <= threshold)
                newColor = 0;
            else
                newColor = 255;


            return Color.FromArgb(a, newColor, newColor, newColor);
        }

        public Color turnOneColorChannel(Color theColor, char channel)
        {

            int a, r, g, b;

            //extract pixel components
            a = theColor.A;
            r = theColor.R;
            g = theColor.G;
            b = theColor.B;

            switch (channel)
            {
                case 'r':
                case 'R':
                    g = 0;
                    b = 0;
                    break;

                case 'g':
                case 'G':
                    r = 0;
                    b = 0;
                    break;

                case 'b':
                case 'B':
                    r = 0;
                    g = 0;
                    break;

                default: 
                    return Color.FromArgb(a, 0, 0, 0);
            }
            
            

            //set new RGB value           

            return Color.FromArgb(a, r, g, b);
        }

        public Bitmap mirrorImage(Bitmap bmap)
        {
            int width, height;

            width = bmap.Width;
            height = bmap.Height;

            Bitmap mBmap = new Bitmap(width * 2, height);

            for(int y = 0; y < height; y++)
            {
                for(int lx = 0, rx = width*2 - 1; lx < width; lx++, rx--)
                {
                    //Get source pixel value
                    Color p = bmap.GetPixel(lx, y);

                    //Set mirror pixel value
                    mBmap.SetPixel(lx, y, p);
                    mBmap.SetPixel(rx, y, p);
                }
            }            

            return mBmap;
        }


        //Histogram methods
        public void getHistogram(Bitmap bmp, char channel, int display)
        {
            if (bmp == null)
                OnHistogramFinished(new Dictionary<int, int>(), channel, display);

            Dictionary<int, int> histo = new Dictionary<int, int>();

            for (int i = 1; i <= 255; i++)
            {
                histo.Add(i, 1);
            }

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Get pixel color 
                    Color c = bmp.GetPixel(x, y);
                    // If it exists in our 'histogram' increment the corresponding value, or add new

                    int colorValue = 0;

                    switch (channel)
                    {
                        case 'R':
                        case 'r':
                            {
                                colorValue = c.R;
                                break;
                            }

                        case 'G':
                        case 'g':
                            {
                                colorValue = c.G;
                                break;
                            }

                        case 'B':
                        case 'b':
                            {
                                colorValue = c.B;
                                break;
                            }
                    }

                    if (histo.ContainsKey(colorValue))
                        histo[colorValue] = histo[colorValue] + 1;

                }
            }

            OnHistogramFinished(histo, channel, display);
        }

        public void getLockBitsHistogram(Bitmap bmp, char channel, int display)
        {
            if (bmp == null)
                OnHistogramFinished(new Dictionary<int, int>(), channel, display);

            Dictionary<int, int> histo = new Dictionary<int, int>();

            for (int i = 1; i <= 255; i++)
            {
                histo.Add(i, 1);
            }

            Bitmap bmap = new Bitmap(bmp);

            unsafe{
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                //Define Variables for bytes per pixel, as ewll as Image Widht and Height
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                //Define a pointer to the first in the locked image.
                //Scan0 gets or sets the address of the first pixel data in the bitmap
                //This can also be thought of as the first scan line in the bitmap
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                //Step thru each pixel in the image using pointers
                //Parallel.For executes a 'for' lopp in which iterations may run in parallel
                Parallel.For(0, heightInPixels, y =>
                {
                    //Use the 'stride' (scanline width) property to step line by line thru the image
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        //GET each pixel color
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];
                    
                        int colorValue = 0;
                        
                        switch (channel)
                        {
                            case 'R':
                            case 'r':
                                {
                                    colorValue = oldRed;
                                    break;
                                }

                            case 'G':
                            case 'g':
                                {
                                    colorValue = oldGreen;
                                    break;
                                }

                            case 'B':
                            case 'b':
                                {
                                    colorValue = oldBlue;
                                    break;
                                }
                        }

                        if (histo.ContainsKey(colorValue))
                            histo[colorValue] = histo[colorValue] + 1;
                    }
                });
                //bmp.UnlockBits(bitmapData);

            }

            OnHistogramFinished(histo, channel, display);
        }


        //Define the Event Handler Delegates
        public event EventHandler<ImageEventArgs> ImageFinished;

        public event EventHandler<HistogramEventArgs> HistogramFinished;

        //Add Event methods
        protected virtual void OnImageFinished(Bitmap bmap)
        {
            ImageFinished?.Invoke(this, new ImageEventArgs() { bmap = bmap });
        }

        protected virtual void OnHistogramFinished(Dictionary<int, int> histo, char channel, int display)
        {
            HistogramFinished?.Invoke(this, new HistogramEventArgs() { histo = histo, channel = channel, display = display}) ;
        }

    }
}
