using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEffects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source.Image = ImageEffects.Properties.Resources.Lenna;
            loadBtns();
        }
        private void GrayscaleEffect(PictureBox source, PictureBox destination, bool preview)
        {
            if (source.Image != null)
            {
                Bitmap image = (Bitmap)source.Image.Clone();
                Bitmap grayScale = null;
                if (preview == true)
                    grayScale = new Bitmap(image, new Size(image.Width / 4, image.Height / 4));
                else
                    grayScale = image;
                int height = grayScale.Size.Height;
                int width = grayScale.Size.Width;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        Color color = grayScale.GetPixel(xCoordinate, yCoordinate);
                        int grayColor = (color.R + color.G + color.B) / 3;
                        grayScale.SetPixel(xCoordinate, yCoordinate, Color.FromArgb(grayColor, grayColor, grayColor));
                    }
                }
                destination.Image = grayScale;
            }
        }

        private void SepiaEffect(PictureBox source, PictureBox destination, bool preview)
        {
            if (source.Image != null)
            {
                Bitmap image = (Bitmap)source.Image.Clone();
                Bitmap sepia = null;
                if(preview == true)
                    sepia = new Bitmap(image, new Size(image.Width/4,image.Height/4));
                else 
                    sepia = image;
                int height = sepia.Size.Height;
                int width = sepia.Size.Width;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        Color color = sepia.GetPixel(xCoordinate, yCoordinate);
                        double grayColor = ((double)(color.R + color.G + color.B)) / 3.0d;
                        Color sepiaColor = Color.FromArgb((byte)grayColor, (byte)(grayColor * 0.95), (byte)(grayColor * 0.82));
                        sepia.SetPixel(xCoordinate, yCoordinate, sepiaColor);
                    }
                }
                destination.Image = sepia;
            }
        }

        private void WavesEffect(PictureBox source, PictureBox destination, bool preview, int distorsion)
        {
            if (source.Image != null)
            {
                Bitmap image = (Bitmap)source.Image.Clone();
                Bitmap waves = null;
                if (preview == true)
                {
                    waves = new Bitmap(image, new Size(image.Width / 4, image.Height / 4));
                    image = waves;
                }
                else
                    waves = image;
                int height = waves.Size.Height;
                int width = waves.Size.Width;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        int xo = (int)(distorsion * Math.Sin(2 * Math.PI * yCoordinate / distorsion));
                        int yo = (int)(distorsion * Math.Cos(2 * Math.PI * xCoordinate / distorsion));
                        xo += xCoordinate;
                        yo += yCoordinate;
                        xo = checkCoordinate(xo, width);
                        yo = checkCoordinate(yo, height);
                        Color color = image.GetPixel(xo, yo);
                        waves.SetPixel(xCoordinate, yCoordinate, color);
                    }
                }
                destination.Image = waves;
            }
        }

        private void GlacialEffect(PictureBox source, PictureBox destination, bool preview)
        {
            if (source.Image != null)
            {
                Bitmap image = (Bitmap)source.Image.Clone();
                Bitmap glacial = null;
                if (preview == true)
                    glacial = new Bitmap(image, new Size(image.Width / 4, image.Height / 4));
                else
                    glacial = image;
                Gradient glacialGr = new Gradient(glacial);
                int height = glacial.Size.Height;
                int width = glacial.Size.Width;
                int red, green, blue;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        Color color = glacial.GetPixel(xCoordinate, yCoordinate);
                        red = glacialGr.gradientR[color.R];
                        green = glacialGr.gradientG[color.G];
                        blue = glacialGr.gradientB[color.B];
                        color = Color.FromArgb((byte)red, (byte)green, (byte)blue);
                        glacial.SetPixel(xCoordinate, yCoordinate, color);
                    }
                }
                destination.Image = glacial;
            }
        }

        private int checkCoordinate(int coord, int limit)
        {
            if (coord >= limit)
                return limit-1;
            else if (coord < 0)
                return 0;
            else
                return coord;
        }

        private void loadBtns()
        {
            GrayscaleEffect(source, grayscaleBtn, true);
            SepiaEffect(source, sepiaBtn, true);
            WavesEffect(source, wavesBtn, true, 2);
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (result.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Bmp;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    result.Image.Save(sfd.FileName, format);
                }
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.bmp) | *.jpg; *.jpeg; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    source.Image = new Bitmap(dlg.FileName);
                    result.Image = null;
                    loadBtns();
                }
            }
        }

        private void wavesBtn_Click(object sender, EventArgs e)
        {
            WavesEffect(source, result, false, 50);
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            SepiaEffect(source, result, false);
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            GrayscaleEffect(source, result, false);
        }

        private void glacialBtn_Click(object sender, EventArgs e)
        {
            GlacialEffect(source, result, false);
        }
    }
}
