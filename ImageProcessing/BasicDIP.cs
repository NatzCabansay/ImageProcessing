using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    static class BasicDIP
    {
        //Contrast
        public static void Equalization(ref Bitmap a, ref Bitmap b, int degree)
        {
            int height = a.Height;
            int width = a.Width;
            int numSamples, histSum;
            int[] Ymap = new int[256];
            int[] hist = new int[256];
            int percent = degree;
            //compute the histogram from the sub-image
            Color sample, gray;
            Byte graydata;
            //Enhanced grayscale conversion
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3); //
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }
            int[] histdata = new int[256];
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.G]++;
                }
            }
            numSamples = (a.Width * a.Height);
            histSum = 0;
            for(int h = 0; h < 256; h++)
            {
                histSum += hist[h];
                Ymap[h] = histSum * 255/numSamples;
            }
            if(percent < 100)
            {
                for(int h=0; h<256; h++)
                {
                    Ymap[h] = h + ((int)Ymap[h] - h) * percent / 100;
                }
            }
            b = new Bitmap(a.Width, a.Height);
            for(int y=0; y<a.Height; y++)
            {
                for(int x=0; x<a.Width; x++)
                {
                    Color temp = Color.FromArgb(Ymap[a.GetPixel(x, y).R], Ymap[a.GetPixel(x, y).G], Ymap[a.GetPixel(x, y).B]);
                    b.SetPixel(x, y, temp);
                }
            }
        }
        public static void Brightness(ref Bitmap a, ref Bitmap b, int value)
        {
            b = new Bitmap(a.Width, a.Height);
            for(int x=0; x<a.Width; x++)
            {
                for(int y=0; y<a.Height; y++)
                {
                    Color temp = a.GetPixel(x, y);
                    Color changed;
                    if (value > 0)
                    {
                        changed = Color.FromArgb(Math.Min(temp.R + value, 255), Math.Min(temp.G + value, 255), Math.Min(temp.B + value, 255));
                    }
                    else //Don't forget that when we add a negative value, we effectively subtract
                    {
                        changed = Color.FromArgb(Math.Max(temp.R + value, 0), Math.Max(temp.G + value, 0), Math.Max(temp.B + value, 0));
                    }
                    b.SetPixel(x, y, changed);
                }
            }
        }
        
        public static void Hist(ref Bitmap a, ref Bitmap b)
        {
            Color sample, gray;
            Byte graydata;
            //Enhanced grayscale conversion
            for(int x=0; x < a.Width; x++)
            {
                for(int y=0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((3*sample.R + 6*sample.G + sample.B) / 10); //
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x,y, gray);
                }
            }
            int[] histdata = new int[256];
            for(int x=0; x<a.Width; x++)
            {
                for(int y=0; y<a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((3 * sample.R + 6 * sample.G + sample.B) / 10);
                    histdata[graydata]++;
                }
            }
            b = new Bitmap(256, 800);
            for(int x=0;x<256; x++)
            {
                for(int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }
            //Plotting points based on histogram
            for(int x=0; x<256; x++)
            {
                for(int y=0; y < Math.Min(histdata[x]/5, b.Height-1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }
    }
}
