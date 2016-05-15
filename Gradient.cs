using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEffects
{
    class Gradient
    {
        public int[] mMValues, gradientR, gradientG, gradientB;

        public Gradient(Bitmap image)
        {
            mMValues = this.getMinMaxValues(image);
            int delta = 255 / (mMValues[4] - mMValues[0]);
            int gradient;
            gradientR=new int[256];
            gradientG=new int[256];
            gradientB = new int[256];
            for (int i = mMValues[0]; i < mMValues[4]; i++)
            {
                gradient = (i - mMValues[0]) * delta;
                gradientR[i] = this.gradientValue(mMValues[1], mMValues[5], gradient);
                gradientG[i] = this.gradientValue(mMValues[2], mMValues[6], gradient);
                gradientB[i] = this.gradientValue(mMValues[3], mMValues[7], gradient);
            }
        }

        private int[] getMinMaxValues(Bitmap image)
        {
            int[] values = new int[] { 255, 255, 255, 255, 0, 0, 0, 0 };
            int global = 0;
            int height = image.Size.Height;
            int width = image.Size.Width;
            for (int yCoordinate = 0; yCoordinate < height; yCoordinate++)
            {
                for (int xCoordinate = 0; xCoordinate < width; xCoordinate++)
                {
                    Color color = image.GetPixel(xCoordinate, yCoordinate);
                    // red min/max
                    if (color.R < values[1])
                        values[1] = color.R;
                    else if (color.R > values[5])
                        values[5] = color.R;
                    // green min/max
                    if (color.G < values[2])
                        values[2] = color.G;
                    else if (color.G > values[6])
                        values[6] = color.G;
                    // blue min/max
                    if (color.B < values[3])
                        values[3] = color.R;
                    else if (color.B > values[7])
                        values[7] = color.B;
                    // global min/max
                    global = Math.Min(color.R, Math.Min(color.G, color.B));
                    if (global < values[0])
                        values[0] = global;
                    global = Math.Max(color.R, Math.Max(color.G, color.B));
                    if (global> values[4])
                        values[4] = global;
                }
            }
            return values;
        }

        private int gradientValue(int min,int max,int gradient) {
            if (gradient == 0 || gradient == 255)
                return min;
            else
                return (min * (255 - gradient) + max * gradient) / 256;
        }
    }
}
