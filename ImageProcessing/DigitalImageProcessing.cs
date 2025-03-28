namespace ImageProcessing
{
    public partial class DigitalImageProcessing : Form
    {
        Bitmap loaded, processed; //loaded goes into the "Before", processed goes into the "After"
        Bitmap imageBG, imageFG, resultImage;


        public DigitalImageProcessing()
        {
            InitializeComponent();
            drpOptions.SelectedIndex = 0; //first item selected by default
        }

        //Open file
        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //Open file
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            picLoaded.Image = loaded;
        }

        //Save file
        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); //Save file
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbcImageProcessing.SelectedTab == tbcImageProcessing.TabPages["tabBasicDigitalImageProcessing"])
            {
                processed.Save(saveFileDialog1.FileName);
            }
            else if (tbcImageProcessing.SelectedTab == tbcImageProcessing.TabPages["tabImageSub"])
            {
                resultImage.Save(saveFileDialog1.FileName);
            }
        }

        void pixelCopy(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y); //Get the pixel from loaded
                    processed.SetPixel(x, y, pixel); //Copy it into processed
                }
            }
        }

        void simpleGrayscale(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int average;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    average = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(average, average, average);
                    processed.SetPixel(x, y, gray); //Copy it into processed
                }
            }
        }

        void enhancedGrayscale(ref Bitmap loaded, ref Bitmap processed) //with rudimentary gamma correction
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int wAverage;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    wAverage = (int)((3 * pixel.R + 6 * pixel.G + 1 * pixel.B) / 10); //green has the highest luminance while blue has the lowest luminance
                    Color gray = Color.FromArgb(wAverage, wAverage, wAverage);
                    processed.SetPixel(x, y, gray); //Copy it into processed
                }
            }
        }

        void invert(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color invert = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, invert); //Copy it into processed
                }
            }
        }

        void sepia(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    int sepiaR = (int)Math.Min(pixel.R * 0.393 + pixel.G * 0.769 + pixel.B * 0.189, 255);
                    int sepiaG = (int)Math.Min(pixel.R * 0.349 + pixel.G * 0.686 + pixel.B * 0.168, 255);
                    int sepiaB = (int)Math.Min(pixel.R * 0.272 + pixel.G * 0.534 + pixel.B * 0.131, 255);
                    Color sepia = Color.FromArgb(sepiaR, sepiaG, sepiaB);
                    processed.SetPixel(x, y, sepia); //Copy it into processed
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            switch (drpOptions.SelectedItem.ToString())
            {
                case "Pixel Copy":
                    {
                        pixelCopy(ref loaded, ref processed);
                        break;
                    }
                case "Simple Grayscale":
                    {
                        simpleGrayscale(ref loaded, ref processed);
                        break;
                    }
                case "Enhanced Grayscale":
                    {
                        enhancedGrayscale(ref loaded, ref processed);
                        break;
                    }
                case "Invert":
                    {
                        invert(ref loaded, ref processed);
                        break;
                    }
                case "Histogram":
                    {
                        BasicDIP.Hist(ref loaded, ref processed);
                        break;
                    }
                case "Sepia":
                    {
                        sepia(ref loaded, ref processed);
                        break;
                    }
            }
            picProcessed.Image = processed;
        }



        private void nspBrightness_ValueChanged(object sender, EventArgs e)
        {
            BasicDIP.Brightness(ref loaded, ref processed, (int)nspBrightness.Value);
            picProcessed.Image = processed;
        }

        private void btnContrastAdjust_Click(object sender, EventArgs e)
        {
            if (cbxEnable.Checked == true)
            {
                BasicDIP.Equalization(ref loaded, ref processed, (int)(100 - nspContrast.Value));
                picProcessed.Image = processed;
            }
        }

        private void cbxEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEnable.Checked == true)
            { //Apply whatever was on there immediately
                BasicDIP.Equalization(ref loaded, ref processed, (int)(100 - nspContrast.Value));
                picProcessed.Image = processed;
            }
            else
            {
                pixelCopy(ref loaded, ref processed);
                picProcessed.Image = processed;
            }
        }

        private void btnReflectH_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel((loaded.Width - 1) - x, y); //Get the pixel from loaded
                    processed.SetPixel(x, y, pixel); //Copy it into processed
                }
            }
            picProcessed.Image = processed;
        }

        private void btnReflectV_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, (loaded.Height - 1) - y); //Get the pixel from loaded
                    processed.SetPixel(x, y, pixel); //Copy it into processed
                }
            }
            picProcessed.Image = processed;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nspRotate.Value = 0;
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageBG = new Bitmap(openFileDialog2.FileName);
            picBackground.Image = imageBG;
        }

        private void btnForeground_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageFG = new Bitmap(openFileDialog3.FileName);
            picForeground.Image = imageFG;
        }

        private void btnGenerateResult_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(imageBG.Width, imageBG.Height);
            Color theGreen = Color.FromArgb(0, 255, 0);
            int graygreen = (3*theGreen.R + 6*theGreen.G + theGreen.B) / 10;
            int threshold = 5;
            for (int x = 0; x < imageBG.Width; x++)
            {
                for (int y = 0; y < imageBG.Height; y++)
                {
                    Color pixel = imageFG.GetPixel(x, y);
                    Color backpixel = imageBG.GetPixel(x, y);
                    int gray = (3*pixel.R + 6*pixel.G + pixel.B) / 10;
                    int subtractValue = Math.Abs(gray - graygreen);
                    if (subtractValue > threshold)
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                }
            }
            picResult.Image = resultImage;
        }
    }
}
