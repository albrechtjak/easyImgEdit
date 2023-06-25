using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace EasyImgEdit
{
    internal class IoClass
    {
        public static void Save(Bitmap bm, PictureBox pic)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Jpg Image|*.jpg" +
                        "|Png Image|*.png" +
                        "|Bmp Image|*.bmp"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                if (sfd.FileName.EndsWith(".jpg"))
                {
                    btm.Save(sfd.FileName, ImageFormat.Jpeg);
                }
                else if (sfd.FileName.EndsWith(".png"))
                {
                    btm.Save(sfd.FileName, ImageFormat.Png);

                }
                else if (sfd.FileName.EndsWith(".bmp"))
                {
                    btm.Save(sfd.FileName, ImageFormat.Bmp);

                }

            }
        }

        public static Bitmap OpenFile(Bitmap bm, PictureBox pic)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(open.FileName);
                if (bm.Width > pic.Width || bm.Height > pic.Height)
                {
                    // Výpočet poměru stran
                    float pomer = Math.Min((float)pic.Width / bm.Width, (float)pic.Height / bm.Height);

                    // Vytvoření bitmapy s novými rozměry
                    Bitmap rszdBm = new Bitmap(bm, new Size((int)(bm.Width * pomer), (int)(bm.Height * pomer)));

                    bm.Dispose();  
                    bm = rszdBm;
                }

                pic.Image = bm;
                pic.Size = new Size(bm.Width, bm.Height);
            }
            return bm;
        }
    }
}
