using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Malovani
{
    internal class IOClass
    {
        public static void Save(Bitmap bm, PictureBox Pic)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Jpg Image|*.jpg" +
                        "|Png Image|*.png" +
                        "|Bmp Image|*.bmp"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bm.PixelFormat);
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

        public static Bitmap OpenFile(Bitmap bm, PictureBox Pic)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(open.FileName);
                if (bm.Width > Pic.Width || bm.Height > Pic.Height)
                {
                    Pic.Image = bm;


                }
                else
                {
                    Pic.Image = bm;
                    Pic.Size = new Size(bm.Width, bm.Height);

                }
            }
            return bm;
        }
    }
}
