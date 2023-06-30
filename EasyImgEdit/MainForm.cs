using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EasyImgEdit
{
    public partial class MainForm : Form
    {
        private Bitmap bm;
        private Graphics g;
        private bool draw = false;
        private Point point1, pointDwn;
        private readonly Pen p = new Pen(Color.Black, 1);
        private readonly Pen eraser = new Pen(Color.White, 10);
        private readonly Pen txtPen = new Pen(Color.Black, 1);
        private int option;
        private Bitmap btmBack = null;
        private int curX, curY, sizX, sizY, dwnX, dwnY;
        private Rectangle screnSize = Screen.PrimaryScreen.WorkingArea;
        private Color nc = Color.Black;
        private readonly ColorDialog cd = new ColorDialog();
        public static byte langOpt = 1;

        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            PBox.Height = screnSize.Height - 50;
            PBox.Width = screnSize.Width - 50;
            bm = new Bitmap(PBox.Width, PBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            PBox.Image = bm;

            g.SmoothingMode = SmoothingMode.HighQuality;
            option = 1;
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;
            txtPen.DashStyle = DashStyle.Dash;
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            pointDwn = e.Location;
            dwnX = e.X;
            dwnY = e.Y;
            CloneAndEnable();
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                switch (option)
                {
                    case 1:
                        point1 = e.Location;
                        g.DrawLine(p, point1, pointDwn);
                        pointDwn = point1;
                        break;
                    case 2:
                        point1 = e.Location;
                        g.DrawLine(eraser, point1, pointDwn);
                        pointDwn = point1;
                        break;
                }
            }
            PBox.Refresh();
            labelPozice.Text = e.Location.ToString();
            curX = e.X;
            curY = e.Y;
            sizX = Math.Abs(e.X - dwnX);
            sizY = Math.Abs(e.Y - dwnY);
        }

        private void PBox_Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (draw)
            {
                switch (option)
                {
                    case 3:
                        g.DrawEllipse(p, Math.Min(dwnX, curX), Math.Min(dwnY, curY), sizX, sizY);
                        break;
                    case 4:
                        g.DrawRectangle(p, Math.Min(dwnX, curX), Math.Min(dwnY, curY), sizX, sizY);
                        break;
                    case 7:
                        g.DrawRectangle(txtPen, Math.Min(dwnX, curX), Math.Min(dwnY, curY), sizX, sizY);
                        break;
                    case 5:
                        g.DrawLine(p, dwnX, dwnY, curX, curY);
                        break;
                }
            }
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            sizX = Math.Abs(curX - dwnX);
            sizY = Math.Abs(curY - dwnY);
            switch (option)
            {
                case 3:
                    g.DrawEllipse(p, dwnX, dwnY, sizX, sizY);
                    break;
                case 4:
                    g.DrawRectangle(p, Math.Min(dwnX, curX), Math.Min(dwnY, curY), sizX, sizY);
                    break;
                case 5:
                    g.DrawLine(p, dwnX, dwnY, curX, curY);
                    break;
                case 7:
                    Rectangle inputrect = new Rectangle(Math.Min(dwnX, curX), Math.Min(dwnY, curY), sizX, sizY);
                    Brush brush = new SolidBrush(p.Color);
                    InputFormString inputfrm = new InputFormString();
                    inputfrm.ShowDialog();
                    g.DrawString(inputfrm.Text1, inputfrm.Font1, brush, inputrect);
                    break;
            }
            sizY = 0;
            sizX = 0;
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
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (option == 6)
            {
                Fill(bm, e.X, e.Y, nc);
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
                Cursor.Current = Cursors.WaitCursor;
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
                Cursor.Current = Cursors.WaitCursor;
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
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void CloneAndEnable()
        {
            btmBack = bm.Clone(new Rectangle(0, 0, PBox.Width, PBox.Height), bm.PixelFormat);
            BackToolStripMenuItem.Enabled = true;
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            option = 1;
            AllBtnstoTransparent();
        }

        private void Rubb_Click(object sender, EventArgs e)
        {
            option = 2;
            AllBtnstoTransparent();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            option = 3;
            AllBtnstoTransparent();
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            option = 4;
            AllBtnstoTransparent();
        }

        private void Line_Click(object sender, EventArgs e)
        {
            option = 5;
            AllBtnstoTransparent();
        }

        private void Filler_Click(object sender, EventArgs e)
        {
            option = 6;
            AllBtnstoTransparent();
            button_Fill.BackColor = Color.Gray;
        }

        private void Text_Click(object sender, EventArgs e)
        {
            option = 7;
            AllBtnstoTransparent();
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
                BackToolStripMenuItem.Enabled = false;
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

        private void CzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            langOpt = 1;
            ChangeLanguage();
        }

        private void EngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            langOpt = 2;
            ChangeLanguage();
        }

        private void ChangeLanguage()
        {
            switch (langOpt)
            {
                case 1:
                    NewToolStripMenuItem.Text = "Nový";
                    OpenToolStripMenuItem.Text = "Otevřít";
                    BackToolStripMenuItem.Text = "Zpět";
                    konecToolStripMenuItem.Text = "Konec";
                    souborToolStripMenuItem.Text = "Soubor";
                    nastaveníToolStripMenuItem.Text = "Nastavení";
                    oAplikaciToolStripMenuItem.Text = "O aplikaci";
                    filtryToolStripMenuItem.Text = "Filtry";
                    Velikost.Text = "Síla";
                    pera.Text = "Pera";
                    černobílýToolStripMenuItem.Text = "Černobílý";
                    sépieToolStripMenuItem.Text = "Sépie";
                    AktualniBarva_Label.Text = "Vybraná barva:";
                    pozicelabel2.Text = "Pozice kurzoru:";
                    jazykToolStripMenuItem.Text = "Jazyk";
                    SetDimObrazkuToolStripMenuItem.Text = "Rozměry obrázku";
                    umísteníPaneluNástojůToolStripMenuItem.Text = "Umístění panelu nástrojů";
                    vlevoToolStripMenuItem.Text = "Vlevo";
                    vpravoToolStripMenuItem.Text = "Vpravo";
                    napovedaToolStripMenuItem.Text = "Nápověda";
                    SaveToolStripMenuItem.Text = "Uložit";
                    czToolStripMenuItem.Text = "Čeština";
                    enToolStripMenuItem.Text = "Angličtina";
                    toolTip1.SetToolTip(button_Color, "Otevře okno pro výběr barvy.");
                    toolTip1.SetToolTip(button_Pencil, "Kreslení od ruky");
                    toolTip1.SetToolTip(buttonElipse, "Kreslení elispy");
                    toolTip1.SetToolTip(button_Line, "Kreslení čáry");
                    toolTip1.SetToolTip(button_Rect, "Kreslení obdélníku");
                    toolTip1.SetToolTip(button_Rubb, "Guma");
                    toolTip1.SetToolTip(button_Fill, "Vyplnit barvou");
                    toolTip1.SetToolTip(button_Text, "Vykreslení textu");
                    toolTip1.SetToolTip(tb, "Nastaví tlouštku čáry");

                    break;
                case 2:
                    NewToolStripMenuItem.Text = "New project";
                    OpenToolStripMenuItem.Text = "Open";
                    BackToolStripMenuItem.Text = "Back";
                    konecToolStripMenuItem.Text = "End";
                    souborToolStripMenuItem.Text = "File";
                    nastaveníToolStripMenuItem.Text = "Settings";
                    oAplikaciToolStripMenuItem.Text = "About";
                    filtryToolStripMenuItem.Text = "Filters";
                    Velikost.Text = "Thick";
                    pera.Text = "ness";
                    černobílýToolStripMenuItem.Text = "Black and White";
                    sépieToolStripMenuItem.Text = "Sepia";
                    AktualniBarva_Label.Text = "Selected color:";
                    pozicelabel2.Text = "Cursor position:";
                    jazykToolStripMenuItem.Text = "Language";
                    SetDimObrazkuToolStripMenuItem.Text = "Picture size";
                    umísteníPaneluNástojůToolStripMenuItem.Text = "Toolbar location";
                    vlevoToolStripMenuItem.Text = "Left";
                    vpravoToolStripMenuItem.Text = "Right";
                    napovedaToolStripMenuItem.Text = "Help";
                    SaveToolStripMenuItem.Text = "Save";
                    czToolStripMenuItem.Text = "Czech";
                    enToolStripMenuItem.Text = "English";
                    toolTip1.SetToolTip(button_Color, "Opens color picker");
                    toolTip1.SetToolTip(button_Pencil, "Drawing by hand");
                    toolTip1.SetToolTip(buttonElipse, "Drawing an elipse");
                    toolTip1.SetToolTip(button_Line, "Drawing a line");
                    toolTip1.SetToolTip(button_Rect, "Drawing a rectangle");
                    toolTip1.SetToolTip(button_Rubb, "Rubber");
                    toolTip1.SetToolTip(button_Fill, "Fill with colour");
                    toolTip1.SetToolTip(button_Text, "Text rendering");
                    toolTip1.SetToolTip(tb, "Set thickness of line");


                    break;
            }
        }
        private void AllBtnstoTransparent()
        {
            button_Pencil.BackColor = Color.Transparent;
            button_Rubb.BackColor = Color.Transparent;
            button_Line.BackColor = Color.Transparent;
            buttonElipse.BackColor = Color.Transparent;
            button_Text.BackColor = Color.Transparent;
            button_Rect.BackColor = Color.Transparent;
            button_Fill.BackColor = Color.Transparent;

            switch (option)
            {
                case 1:
                    button_Pencil.BackColor = Color.Gray;
                    break;
                case 2:
                    button_Rubb.BackColor = Color.Gray;
                    break;
                case 3:
                    buttonElipse.BackColor = Color.Gray;
                    break;
                case 4:
                    button_Rect.BackColor = Color.Gray;
                    break;
                case 5:
                    button_Line.BackColor = Color.Gray;
                    break;
                case 6:
                    button_Fill.BackColor = Color.Gray;
                    break;
                case 7:
                    button_Text.BackColor = Color.Gray;
                    break;
            }
        }
        private void SouborToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (btmBack == null)
            {
                BackToolStripMenuItem.Enabled = false;
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