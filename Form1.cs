using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEffects
{
    public partial class Form1 : Form
    {
        int shrinkFactor = 6;
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
                Bitmap sourceBitmap = null;
                if (preview == true)
                    sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
                else
                    sourceBitmap = image;
                int height = sourceBitmap.Size.Height;
                int width = sourceBitmap.Size.Width;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        Color color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                        int grayColor = (color.R + color.G + color.B) / 3;
                        sourceBitmap.SetPixel(xCoordinate, yCoordinate, Color.FromArgb(grayColor, grayColor, grayColor));
                    }
                }
                destination.Image = sourceBitmap;
            }
        }

        private void SepiaEffect(PictureBox source, PictureBox destination, bool preview)
        {
            if (source.Image != null)
            {
                Bitmap image = (Bitmap)source.Image.Clone();
                Bitmap sourceBitmap = null;
                if(preview == true)
                    sourceBitmap = new Bitmap(image, new Size(image.Width/shrinkFactor,image.Height/shrinkFactor));
                else 
                    sourceBitmap = image;
                int height = sourceBitmap.Size.Height;
                int width = sourceBitmap.Size.Width;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        Color color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                        double grayColor = ((double)(color.R + color.G + color.B)) / 3.0d;
                        Color sepiaColor = Color.FromArgb((byte)grayColor, (byte)(grayColor * 0.95), (byte)(grayColor * 0.82));
                        sourceBitmap.SetPixel(xCoordinate, yCoordinate, sepiaColor);
                    }
                }
                destination.Image = sourceBitmap;
            }
        }

        private void WavesEffect(PictureBox source, PictureBox destination, bool preview, int distorsion)
        {
            if (source.Image != null)
            {
                Bitmap image = (Bitmap)source.Image.Clone();
                Bitmap sourceBitmap = null;
                if (preview == true)
                {
                    sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
                    image = sourceBitmap;
                }
                else
                    sourceBitmap = image;
                int height = sourceBitmap.Size.Height;
                int width = sourceBitmap.Size.Width;
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
                        sourceBitmap.SetPixel(xCoordinate, yCoordinate, color);
                    }
                }
                destination.Image = sourceBitmap;
            }
        }

        public void ColorTintEffect(PictureBox source, PictureBox destination, bool blueTint,
                                 bool greenTint, bool redTint, bool preview)
        {
            Bitmap image = (Bitmap)source.Image.Clone();
            Bitmap sourceBitmap = null;
            if (preview == true)
                sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
            else
                sourceBitmap = image;
            int height = sourceBitmap.Size.Height;
            int width = sourceBitmap.Size.Width;
            double red, green, blue;
            for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
            {
                for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                {
                    Color color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                    //red = color.R + (255 - color.R) * redTint;
                    //green = color.G + (255 - color.G) * greenTint;
                    //blue = color.B + (255 - color.B) * blueTint;
                    if (blueTint)
                    {
                        blue = color.B;
                        green = color.G - 255;
                        red = color.R - 255;
                    }
                    else if (redTint)
                    {
                        red = color.R;
                        green = color.G - 255;
                        blue = color.B - 255;
                    }
                    else if (greenTint)
                    {
                        green = color.G;
                        red = color.R - 255;
                        blue = color.B - 255;
                    }
                    else
                    {
                        red = color.R;
                        green = color.G;
                        blue = color.B;
                    }
                    red = checkColor((int)red);
                    green = checkColor((int)green);
                    blue = checkColor((int)blue);
                    Color sepiaColor = Color.FromArgb((byte)red, (byte)green, (byte)blue);
                    sourceBitmap.SetPixel(xCoordinate, yCoordinate, sepiaColor);
                }
            }

            destination.Image = sourceBitmap;
        }

        public void MetalicEffect(PictureBox source, PictureBox destination, bool preview, int level)
        {
            int[] mtab = new int[260];
            for (int j = 0; j < 255;)
            {
                for (int k = 0; k < 256; k += level)
                {
                    mtab[j++] = k;
                }
                for (int k = 255; k > 0; k -= level)
                {
                    mtab[j++] = k;
                }
            }
            mtab[255] = level%2==0?0:255;

            Bitmap image = (Bitmap)source.Image.Clone();
            Bitmap sourceBitmap = null;
            if (preview == true)
                sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
            else
                sourceBitmap = image;
            int height = sourceBitmap.Size.Height;
            int width = sourceBitmap.Size.Width;
            int red, green, blue;
            for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
            {
                for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                {
                    Color color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                    red = mtab[color.R];
                    green = mtab[color.G];
                    blue = mtab[color.B];
                    red = checkColor((int)red);
                    green = checkColor((int)green);
                    blue = checkColor((int)blue);
                    Color sepiaColor = Color.FromArgb((byte)red, (byte)green, (byte)blue);
                    sourceBitmap.SetPixel(xCoordinate, yCoordinate, sepiaColor);
                }
            }

            destination.Image = sourceBitmap;
        }

        public void GlassEffect(PictureBox source, PictureBox destination, bool preview, int style, int frequency, int amplitude)
        {
            Bitmap image = (Bitmap)source.Image.Clone();
            Bitmap sourceBitmap = null;
            if (preview == true)
                sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
            else
                sourceBitmap = image;
            int height = sourceBitmap.Size.Height;
            int width = sourceBitmap.Size.Width;
            double nx, ny;
            for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
            {
                for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                {
                    Color color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                    if (style % 2 == 0)
                    {
                        nx = width / 2 - xCoordinate;
                        ny = height / 2 - yCoordinate;
                        nx = xCoordinate + amplitude * Math.Sin(frequency * nx * Math.PI / 180);
                        ny = yCoordinate + amplitude * Math.Cos(frequency * nx * Math.PI / 180);
                    }
                    else
                    {
                        nx = xCoordinate + amplitude * Math.Sin(frequency * xCoordinate * Math.PI / 180);
                        ny = yCoordinate + amplitude * Math.Cos(frequency * yCoordinate * Math.PI / 180);
                    }
                    nx = checkCoordinate((int)nx, width);
                    ny = checkCoordinate((int)ny, height);
                    color = sourceBitmap.GetPixel((int)nx, (int)ny);
                    sourceBitmap.SetPixel(xCoordinate, yCoordinate, color);
                }
            }

            destination.Image = sourceBitmap;
        }

        public void RockEffect(PictureBox source, PictureBox destination, bool preview, int intensity)
        {
            Bitmap image = (Bitmap)source.Image.Clone();
            Bitmap sourceBitmap = null;
            if (preview == true)
                sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
            else
                sourceBitmap = image;
            int height = sourceBitmap.Size.Height;
            int width = sourceBitmap.Size.Width;
            int red, green, blue;
            for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
            {
                for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                {
                    Color color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                    int nextX = checkCoordinate(xCoordinate + 1, width);
                    int nextY = checkCoordinate(yCoordinate + 1, height);
                    Color nextColor = sourceBitmap.GetPixel(nextX, nextY);
                    red = color.R + intensity * (color.R - nextColor.R);
                    green = color.G + intensity * (color.G - nextColor.G);
                    blue = color.B + intensity * (color.B - nextColor.G);
                    red = checkColor(red);
                    green = checkColor(green);
                    blue = checkColor(blue);
                    color = Color.FromArgb(red, green, blue);
                    sourceBitmap.SetPixel(xCoordinate, yCoordinate, color);
                }
            }
            destination.Image = sourceBitmap;
        }

        public void InvertEffect(PictureBox source, PictureBox destination, bool preview)
        {
            Bitmap image = (Bitmap)source.Image.Clone();
            Bitmap sourceBitmap = null;
            if (preview == true)
                sourceBitmap = new Bitmap(image, new Size(image.Width / shrinkFactor, image.Height / shrinkFactor));
            else
                sourceBitmap = image;
            int height = sourceBitmap.Size.Height;
            int width = sourceBitmap.Size.Width;
            
            Color color;
            for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
            {
                for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                {
                    color = sourceBitmap.GetPixel(xCoordinate, yCoordinate);
                    sourceBitmap.SetPixel(xCoordinate, yCoordinate, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                }
            }
            destination.Image = sourceBitmap;
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
        private int checkColor(int color)
        {
            if (color > 255)
                color = 255;
            else if (color < 0)
                color = 0;
            return color;
        }

        private void loadBtns()
        {
            GrayscaleEffect(source, grayscaleBtn, true);
            SepiaEffect(source, sepiaBtn, true);
            WavesEffect(source, wavesBtn, true, 2);
            ColorTintEffect(source, blueTintBtn, true,false,false,true);
            ColorTintEffect(source, redTintBtn, false, false, true, true);
            ColorTintEffect(source, greenTintBtn, false, true, false, true);
            MetalicEffect(source, metalicBtn, true, 10);
            GlassEffect(source, glassBtn, true, 1, 20, 5);
            RockEffect(source, rockBtn, true, 10);
            InvertEffect(source, invertBtn, true);
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
            ColorTintEffect(source, result, true,false, false,false);
        }

        private void redTintBtn_Click(object sender, EventArgs e)
        {
            ColorTintEffect(source, result, false, false, true, false);
        }

        private void greenTintBtn_Click(object sender, EventArgs e)
        {
            ColorTintEffect(source, result, false, true, false, false);
        }

        private void metalicBtn_Click(object sender, EventArgs e)
        {
            MetalicEffect(source, result, false, 10);
        }

        private void glassBtn_Click(object sender, EventArgs e)
        {
            GlassEffect(source, result, false, 1, 20, 5);
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            RockEffect(source, result, false, 10);
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            InvertEffect(source, result, false);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana-Maria Nichifor\nCalculatoare\nAn 3\nGrupa 3132A", "Author");
        }
    }
}
