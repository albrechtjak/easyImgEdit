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
        private readonly Pen eraser = new Pen(Color.White, 10);
        private int option;
        private Bitmap btmBack = null;
        private int curX, curY, sizX, sizY, dwnX, dwnY;
        private Rectangle screnSize = Screen.PrimaryScreen.WorkingArea;
        private Color nc;
        private readonly ColorDialog cd = new ColorDialog();

        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(
                ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
                true);

            PBox.Height = screnSize.Height - 50;
            PBox.Width = screnSize.Width - 50;
            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;

            g.SmoothingMode = SmoothingMode.HighQuality;
            option = 1;
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
                if (option == 1)
                {
                    point1 = e.Location;
                    g.DrawLine(p, point1, point2);
                    point2 = point1;
                }

                if (option == 2)
                {
                    point1 = e.Location;
                    g.DrawLine(eraser, point1, point2);
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
            switch (option)
            {
                case 3:
                    g.DrawEllipse(p, dwnX, dwnY, sizX, sizY);
                    break;
                case 4:
                    g.DrawRectangle(p, dwnX, dwnY, sizX, sizY);
                    break;
                case 5:
                    g.DrawLine(p, dwnX, dwnY, curX, curY);
                    break;
                case 7:
                    Rectangle inputrect = new Rectangle(dwnX, dwnY, sizX, sizY);
                    Brush brush = new SolidBrush(p.Color);

                    InputFormString inputfrm = new InputFormString();
                    inputfrm.ShowDialog();

                    g.DrawString(inputfrm.Text1, inputfrm.Font1, brush, inputrect);
                    break;
            }
        }

        private void PBox_Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (draw)
            {
                switch (option)
                {
                    case 3:
                        g.DrawEllipse(p, dwnX, dwnY, sizX, sizY);
                        break;
                    case 4:
                    case 7:
                        g.DrawRectangle(p, dwnX, dwnY, sizX, sizY);
                        break;
                    case 5:
                        g.DrawLine(p, dwnX, dwnY, curX, curY);
                        break;
                }
            }
        }

        private void SetDimPic(object sender, EventArgs e)
        {
            InputDim frm = new InputDim();
            frm.ShowDialog();
            PBox.Dock = DockStyle.None;
            PBox.Size = new Size(frm.SetWidth, frm.SetHeight);
            PBox.Size = new Size(frm.SetWidth, frm.SetHeight);

            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;
        }

        private void PixelControl(Bitmap bm, Stack<Point> sp, int x, int y, Color oc, Color nc)
        {
            Color c = bm.GetPixel(x, y);
            if (c == oc)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, nc);
            }
        }


        public void Fill(Bitmap bm, int x, int y, Color nc)
        {
            Color oc = bm.GetPixel(x, y);
            Stack<Point> pixStack = new Stack<Point>();
            pixStack.Push(new Point(x, y));
            bm.SetPixel(x, y, nc);
            if (oc == nc)
            {
                return;
            }

            while (pixStack.Count > 0)
            {
                Point bod = pixStack.Pop();
                if (bod.X > 0 && bod.Y > 0 && bod.X < bm.Width - 1 && bod.Y < bm.Height - 1)
                {
                    PixelControl(bm, pixStack, bod.X - 1, bod.Y, oc, nc);
                    PixelControl(bm, pixStack, bod.X, bod.Y - 1, oc, nc);
                    PixelControl(bm, pixStack, bod.X + 1, bod.Y, oc, nc);
                    PixelControl(bm, pixStack, bod.X, bod.Y + 1, oc, nc);
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
            if (option == 6)
            {
                Point pnt = PointForFill(PBox, e.Location);
                Fill(bm, pnt.X, pnt.Y, nc);
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
            option = 1;
        }

        private void Rubb_Click(object sender, EventArgs e)
        {
            option = 2;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            option = 3;
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            option = 4;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            option = 5;
        }

        private void Filler_Click(object sender, EventArgs e)
        {
            option = 6;
        }

        private void Text_Click(object sender, EventArgs e)
        {
            option = 7;
        }

        private void VlevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolPanel.Dock = DockStyle.Left;
            PBox.Location = new Point(48, 24);
        }

        private void VpravoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolPanel.Dock = DockStyle.Right;
            PBox.Location = new Point(0, 24);
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
            ChangeColor(Color.Black);
        }

        private void ChangeColor(Color b)
        {
            p.Color = b;
            currColor.BackColor = b;
            nc = b;
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

        private void KonecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ChangeColor(cd.Color);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBox.Height = screnSize.Height - 50;
            PBox.Width = screnSize.Width - 50;
            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;
            option = 1;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm = IoClass.OpenFile(bm, PBox);
            g = Graphics.FromImage(bm);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IoClass.Save(bm, PBox);
        }
    }
}