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

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.bmp) | *.jpg; *.jpeg; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    pictureBox2.Image = null;
                    loadBtns();
                }
            }
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
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
                    pictureBox2.Image.Save(sfd.FileName, format);
                }
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = grayscaleBtn.Image;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = sepiaBtn.Image;
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = grayscaleBtn.Image;
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = sepiaBtn.Image;
        }

        private void GrayscaleEffect(PictureBox source, PictureBox destination)
        {
            if (source.Image != null)
            {
                Bitmap grayScale = (Bitmap)source.Image.Clone();
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

        private void SepiaEffect(PictureBox source, PictureBox destination)
        {
            if (source.Image != null)
            {
                Bitmap grayScale = (Bitmap)source.Image.Clone();
                int height = grayScale.Size.Height;
                int width = grayScale.Size.Width;
                for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
                {
                    for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                    {
                        Color color = grayScale.GetPixel(xCoordinate, yCoordinate);
                        double grayColor = ((double)(color.R + color.G + color.B)) / 3.0d;
                        Color sepia = Color.FromArgb((byte)grayColor, (byte)(grayColor * 0.95), (byte)(grayColor * 0.82));
                        grayScale.SetPixel(xCoordinate, yCoordinate, sepia);
                    }
                }
                destination.Image = grayScale;
            }
        }

        private void loadBtns()
        {
            GrayscaleEffect(pictureBox1, grayscaleBtn);
            SepiaEffect(pictureBox1, sepiaBtn);
            grayscaleBtn.Visible = true;
            label1.Visible = true;
            sepiaBtn.Visible = true;
            label2.Visible = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

    }
}
