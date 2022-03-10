using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        readonly Pen p = new Pen(Color.Black, 1);
        readonly Pen Eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;

        Color New_Color;
        readonly ColorDialog cd = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
            Rectangle screeensize = Screen.PrimaryScreen.WorkingArea;

            Pic.Height = screeensize.Height -50;
            Pic.Width = screeensize.Width -70;
            bm = new Bitmap(Pic.Width, Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
            
            g.SmoothingMode = SmoothingMode.HighQuality;
            index = 1;

        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(Eraser, px, py);
                    py = px;
                }
            }
            Pic.Refresh();            

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;
            if (index == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (index == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                    
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
                if (index == 7)
                {
                    g.DrawString("My String", this.Font, Brushes.Black, ClientRectangle);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            index = 0;
        }

        private void BtnPaint_Click(object sender, EventArgs e)
        {
            New_Color = p.Color;
            index = 6;
        }    
        static Point Set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }



        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }

        private void SetDimPic(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();            
            Pic.Dock = DockStyle.None;
            Pic.Size = new Size(frm.SetWidth, frm.SetHeight);
            
            bm = new Bitmap(Pic.Width, Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
            
        }

        private void Tb_ValueChanged(object sender, EventArgs e)
        {
            p.Width = tb.Value;
            label2.Text = tb.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CernobilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bm.Width; y++)
            {
                for (int x = 0; x < bm.Height; x++)
                {
                    Color oc = bm.GetPixel(y, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    bm.SetPixel(y, x, nc);
                }
            }
        }
        private void NegativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bm.Width; y++)
            {
                for (int x = 0; x < bm.Height; x++)
                {
                    Color inv = bm.GetPixel(y, x);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    bm.SetPixel(y, x, inv);
                }
            }

        }

        private void SepieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    //přiřazení barvy pixelu
                    Color c = bm.GetPixel(x, y);

                    //rozřazení pixelů do ARGB
                    int a = c.A;
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    //výpočet temp barev
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);
                    //nastavení nových RGB barev
                    if (tr > 255)
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

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }
                    //nastavení nové barvy pixelu
                    bm.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
        }

        private void VlevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolPanel.Dock = DockStyle.Left;
        }

        private void VpravoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolPanel.Dock = DockStyle.Right;
            Pic.Dock = DockStyle.Left;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
            currColor.BackColor = p.Color;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            p.Color = Color.FromArgb(255,102,0);
            currColor.BackColor = p.Color;

        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
            currColor.BackColor = p.Color;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
            currColor.BackColor = p.Color;                 
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
            currColor.BackColor = p.Color;
        }

        private void Magneta_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
            currColor.BackColor = p.Color;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            p.Color = Color.FromArgb(255, 192, 255);
            currColor.BackColor = p.Color;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            p.Color = Color.FromArgb(155, 103, 60);
            currColor.BackColor = p.Color;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gray;
            currColor.BackColor = p.Color;
        }

        private void White_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
            currColor.BackColor = p.Color;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
            currColor.BackColor = p.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void OAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAbout f = new FAbout();
            f.Show();
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                Point point = Set_Point(Pic, e.Location);
                Fill(bm, point.X, point.Y, New_Color);
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();           
            p.Color = cd.Color;
            currColor.BackColor = p.Color;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            index = 1;
            
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
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
                    g = Graphics.FromImage(bm);
                    Pic.Image = bm;

                }
                else
                {
                    g = Graphics.FromImage(bm);
                    Pic.Image = bm;
                    Pic.Size = new Size(bm.Width, bm.Height);
                }
                
                g.SmoothingMode = SmoothingMode.HighQuality;

            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Jpg Image|*.jpg" +
                        "|Png Image|*.png" +
                        "|Bmp Image|*.bmp"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int picw = Pic.Width;
                int pich = Pic.Height;
                MessageBox.Show(picw.ToString() + " " + pich.ToString());
                Bitmap btm = bm.Clone(new Rectangle(0, 0, picw, pich), bm.PixelFormat);
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
    }
}
