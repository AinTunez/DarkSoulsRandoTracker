using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DSItemTracker
{
    public partial class KeyDisplay : UserControl
    {
        public string Name;
        public readonly int ID;
        public bool Collected = false;
        public Color Found;
        public Color Missing;
        private Image Item;

        public KeyDisplay(string name, int id, Image img, Color f, Color m)
        {
            InitializeComponent();
            SizeChanged += KeyDisplay_SizeChanged;
            Found = f;
            Missing = m;
            KeyName.Width = Width;
            KeyName.Dock = DockStyle.Bottom;
            KeyName.Text = name;
            Name = name;
            Item = img;
            ID = id;
            SetFound(false, true);
        }

        private void KeyDisplay_SizeChanged(object sender, EventArgs e) => KeyName.Width = Width;

        public void SetFound(bool isFound, bool force = false)
        {
            if (!force && isFound == Collected) return;
            Collected = isFound;
            KeyPic.Image = isFound ? Item : AdjustImage(Item, 0.2f, 0f);
            KeyName.ForeColor = isFound ? Found : Missing;
        }

        private Bitmap AdjustImage(Image image, float brightness, float saturation)
        {
            // Make the ColorMatrix.
            float b = brightness;
            float s = saturation;
            ColorMatrix cm = new ColorMatrix(
                new float[][]
                {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {s, s, s, 0, 0},
                });


            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Draw the image onto the new bitmap while applying
            // the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            Graphics.FromImage(bm).DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);

            // Return the result.
            return bm;
        }


        private static Bitmap SetAlpha(Image bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, a, 0},
            new float[] {0, 0, 0, 0, 0}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        private static Bitmap MakeGrayscale3(Image original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }


    }
}
