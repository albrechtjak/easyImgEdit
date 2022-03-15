using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Malovani
{
    public partial class MainForm : Form
    {
        private Bitmap bm;
        private Graphics g;
        private bool draw = false;
        private Point point1, point2;
        private readonly Pen p = new Pen(Color.Black, 1);
        private readonly Pen Eraser = new Pen(Color.White, 10);
        private int Option;
        private Bitmap btmBack = null;
        private int curX, curY, sizX, sizY, dwnX, dwnY;
        private Rectangle screeensize = Screen.PrimaryScreen.WorkingArea;
        private Color NC;
        private readonly ColorDialog cd = new ColorDialog();
        public MainForm()
        {
            InitializeComponent();

            PBox.Height = screeensize.Height - 50;
            PBox.Width = screeensize.Width - 50;
            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;

            g.SmoothingMode = SmoothingMode.HighQuality;
            Option = 1;

        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            point2 = e.Location;
            dwnX = e.X;
            dwnY = e.Y;
            CloneAndEnable();

        }
        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (Option == 1)
                {
                    point1 = e.Location;
                    g.DrawLine(p, point1, point2);
                    point2 = point1;
                }
                if (Option == 2)
                {
                    point1 = e.Location;
                    g.DrawLine(Eraser, point1, point2);
                    point2 = point1;
                }
            }
            PBox.Refresh();
            labelPozice.Text = "Pozice kurzoru " + e.Location.ToString();
            curX = e.X;
            curY = e.Y;
            sizX = e.X - dwnX;
            sizY = e.Y - dwnY;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            sizX = curX - dwnX;
            sizY = curY - dwnY;
            if (Option == 3)
            {
                g.DrawEllipse(p, dwnX, dwnY, sizX, sizY);
            }
            if (Option == 4)
            {
                g.DrawRectangle(p, dwnX, dwnY, sizX, sizY);
            }
            if (Option == 5)
            {
                g.DrawLine(p, dwnX, dwnY, curX, curY);
            }
            if (Option == 7)
            {
                Rectangle inputrect = new Rectangle(dwnX, dwnY, sizX, sizY);
                Brush brush = new SolidBrush(p.Color);

                InputFormString inputfrm = new InputFormString();
                inputfrm.ShowDialog();

                g.DrawString(inputfrm.Text1, inputfrm.Font1, brush, inputrect);

            }
        }
        private void PBox_Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (draw)
            {
                if (Option == 3)
                {
                    g.DrawEllipse(p, dwnX, dwnY, sizX, sizY);
                }

                if (Option == 4)
                {
                    g.DrawRectangle(p, dwnX, dwnY, sizX, sizY);
                }
                if (Option == 5)
                {
                    g.DrawLine(p, dwnX, dwnY, curX, curY);
                }
                if (Option == 7)
                {
                    g.DrawRectangle(p, dwnX, dwnY, sizX, sizY);
                }
            }
        }
        private void SetDimPic(object sender, EventArgs e)
        {
            InputDim frm = new InputDim();
            frm.ShowDialog();
            PBox.Dock = DockStyle.None;
            PBox.Size = new Size(frm.SetWidth, frm.SetHeight);

            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;
        }

        private void PixelControl(Bitmap bm, Stack<Point> sp, int x, int y, Color OC, Color NC)
        {
            Color c = bm.GetPixel(x, y);
            if (c == OC)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, NC);
            }
        }


        public void Fill(Bitmap bm, int x, int y, Color NC)
        {
            Color OC = bm.GetPixel(x, y);
            Stack<Point> pixStack = new Stack<Point>();
            pixStack.Push(new Point(x, y));
            bm.SetPixel(x, y, NC);
            if (OC == NC) { return; }

            while (pixStack.Count > 0)
            {
                Point bod = pixStack.Pop();
                if (bod.X > 0 && bod.Y > 0 && bod.X < bm.Width - 1 && bod.Y < bm.Height - 1)
                {
                    PixelControl(bm, pixStack, bod.X - 1, bod.Y, OC, NC);
                    PixelControl(bm, pixStack, bod.X, bod.Y - 1, OC, NC);
                    PixelControl(bm, pixStack, bod.X + 1, bod.Y, OC, NC);
                    PixelControl(bm, pixStack, bod.X, bod.Y + 1, OC, NC);
                }
            }
        }
        private static Point PointForFill(PictureBox pic, Point bod)
        {
            float pntX = 1f * pic.Width / pic.Width;
            float pntY = 1f * pic.Height / pic.Height;
            return new Point((int)(bod.X * pntX), (int)(bod.Y * pntY));
        }
        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (Option == 6)
            {
                Point pnt = PointForFill(PBox, e.Location);
                Fill(bm, pnt.X, pnt.Y, NC);
            }
        }
        private void Tb_ValueChanged(object sender, EventArgs e)
        {
            p.Width = tb.Value;
            silaPera.Text = tb.Value.ToString();
        }
        private void CernobilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloneAndEnable();
            for (int y = 0; y < bm.Width; y++)
            {
                for (int x = 0; x < bm.Height; x++)
                {
                    Color oldC = bm.GetPixel(y, x);
                    int grayScale = (int)((oldC.R * 0.3) + (oldC.G * 0.59) + (oldC.B * 0.11));
                    Color newC = Color.FromArgb(oldC.A, grayScale, grayScale, grayScale);
                    bm.SetPixel(y, x, newC);
                }
            }
        }
        private void NegativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloneAndEnable();
            for (int y = 0; y < bm.Width; y++)
            {
                for (int x = 0; x < bm.Height; x++)
                {
                    Color oldC = bm.GetPixel(y, x);
                    Color newC = Color.FromArgb(255, (255 - oldC.R), (255 - oldC.G), (255 - oldC.B));
                    bm.SetPixel(y, x, newC);
                }
            }

        }
        private void SepieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloneAndEnable();
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    //přiřazení barvy pixelu
                    Color oldC = bm.GetPixel(x, y);

                    //rozřazení pixelů do ARGB
                    int a = oldC.A;
                    int r = oldC.R;
                    int g = oldC.G;
                    int b = oldC.B;
                    //výpočet temp barev
                    int tr = (int)(0.392 * r + 0.768 * g + 0.188 * b);
                    int tg = (int)(0.348 * r + 0.687 * g + 0.168 * b);
                    int tb = (int)(0.271 * r + 0.535 * g + 0.132 * b);
                    //nastavení nových RGB barev
                    r = tr > 255 ? 255 : tr;
                    g = tg > 255 ? 255 : tg;
                    b = tb > 255 ? 255 : tb;
                    //nastavení nové barvy pixelu
                    bm.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
        }
        private void CloneAndEnable()
        {
            btmBack = bm.Clone(new Rectangle(0, 0, PBox.Width, PBox.Height), bm.PixelFormat);
            zpětToolStripMenuItem.Enabled = true;
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            Option = 1;
        }

        private void Rubb_Click(object sender, EventArgs e)
        {
            Option = 2;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            Option = 3;
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            Option = 4;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            Option = 5;
        }

        private void Filler_Click(object sender, EventArgs e)
        {
            Option = 6;
        }

        private void Text_Click(object sender, EventArgs e)
        {
            Option = 7;
        }

        private void VlevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolPanel.Dock = DockStyle.Left;
        }

        private void VpravoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolPanel.Dock = DockStyle.Right;
            PBox.Dock = DockStyle.Left;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Red);
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(255, 102, 0));
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Yellow);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Green);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Blue);
        }

        private void Magneta_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Purple);
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(255, 192, 255));
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(155, 103, 60));
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Gray);
        }

        private void White_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.White);
        }

        private void Black_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
            currColor.BackColor = p.Color;
        }
        private void ChangeColor(Color b)
        {
            p.Color = b;
            currColor.BackColor = b;
            NC = b;
        }



        private void ZpetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btmBack == null)
            {
                zpětToolStripMenuItem.Enabled = false;

            }
            else
            {
                bm = btmBack;
                PBox.Image = bm;
                g = Graphics.FromImage(bm);
                btmBack = null;
            }

        }

        private void SouborToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (btmBack == null)
            {
                zpětToolStripMenuItem.Enabled = false;
            }
        }

        private void OAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAbout f = new FAbout();
            f.Show();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            p.Color = cd.Color;
            currColor.BackColor = p.Color;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBox.Height = screeensize.Height - 50;
            PBox.Width = screeensize.Width - 50;
            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;
            Option = 1;

        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm = IOClass.OpenFile(bm, PBox);
            g = Graphics.FromImage(bm);

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOClass.Save(bm, PBox);
        }
    }
}