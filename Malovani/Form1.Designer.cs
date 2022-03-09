namespace Malovani
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Velikost = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TrackBar();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetDimObrazkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umísteníPaneluNástojůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vpravoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.černobílýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sépieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.currColor = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.Magneta = new System.Windows.Forms.Button();
            this.AktualniBarva_Label = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.ToolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.ColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.AutoSize = true;
            this.ToolPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToolPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToolPanel.Controls.Add(this.label2);
            this.ToolPanel.Controls.Add(this.Velikost);
            this.ToolPanel.Controls.Add(this.tb);
            this.ToolPanel.Controls.Add(this.BtnColor);
            this.ToolPanel.Controls.Add(this.BtnPaint);
            this.ToolPanel.Controls.Add(this.BtnLine);
            this.ToolPanel.Controls.Add(this.BtnRectangle);
            this.ToolPanel.Controls.Add(this.BtnEllipse);
            this.ToolPanel.Controls.Add(this.BtnEraser);
            this.ToolPanel.Controls.Add(this.BtnPencil);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(0, 24);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(69, 725);
            this.ToolPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "1";
            // 
            // Velikost
            // 
            this.Velikost.AutoSize = true;
            this.Velikost.Location = new System.Drawing.Point(9, 533);
            this.Velikost.Name = "Velikost";
            this.Velikost.Size = new System.Drawing.Size(49, 13);
            this.Velikost.TabIndex = 7;
            this.Velikost.Text = "Tloušťka";
            // 
            // tb
            // 
            this.tb.AutoSize = false;
            this.tb.Location = new System.Drawing.Point(12, 549);
            this.tb.Maximum = 25;
            this.tb.Minimum = 1;
            this.tb.Name = "tb";
            this.tb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb.Size = new System.Drawing.Size(50, 197);
            this.tb.TabIndex = 5;
            this.tb.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb.Value = 1;
            this.tb.ValueChanged += new System.EventHandler(this.Tb_ValueChanged);
            // 
            // BtnColor
            // 
            this.BtnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnColor.BackgroundImage")));
            this.BtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColor.FlatAppearance.BorderSize = 0;
            this.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.Color.Transparent;
            this.BtnColor.Location = new System.Drawing.Point(12, 17);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(50, 50);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnPaint
            // 
            this.BtnPaint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPaint.BackgroundImage")));
            this.BtnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPaint.FlatAppearance.BorderSize = 0;
            this.BtnPaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaint.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPaint.Location = new System.Drawing.Point(12, 438);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(50, 50);
            this.BtnPaint.TabIndex = 5;
            this.BtnPaint.UseVisualStyleBackColor = false;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLine.BackgroundImage")));
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.FlatAppearance.BorderSize = 0;
            this.BtnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLine.Location = new System.Drawing.Point(12, 228);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(50, 50);
            this.BtnLine.TabIndex = 4;
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRectangle.BackgroundImage")));
            this.BtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRectangle.FlatAppearance.BorderSize = 0;
            this.BtnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRectangle.Location = new System.Drawing.Point(12, 369);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(50, 50);
            this.BtnRectangle.TabIndex = 3;
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEllipse.BackgroundImage")));
            this.BtnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEllipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEllipse.FlatAppearance.BorderSize = 0;
            this.BtnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllipse.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEllipse.Location = new System.Drawing.Point(12, 298);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(50, 50);
            this.BtnEllipse.TabIndex = 2;
            this.BtnEllipse.UseVisualStyleBackColor = true;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEraser.BackgroundImage")));
            this.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEraser.FlatAppearance.BorderSize = 0;
            this.BtnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEraser.Location = new System.Drawing.Point(12, 160);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(50, 50);
            this.BtnEraser.TabIndex = 1;
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPencil.BackgroundImage")));
            this.BtnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPencil.FlatAppearance.BorderSize = 0;
            this.BtnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPencil.Location = new System.Drawing.Point(12, 89);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(50, 50);
            this.BtnPencil.TabIndex = 0;
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.nastaveníToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.nápovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.NewToolStripMenuItem.Text = "Nový";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.OpenToolStripMenuItem.Text = "Otevřít";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SaveToolStripMenuItem.Text = "Uložit";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetDimObrazkuToolStripMenuItem,
            this.umísteníPaneluNástojůToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // SetDimObrazkuToolStripMenuItem
            // 
            this.SetDimObrazkuToolStripMenuItem.Name = "SetDimObrazkuToolStripMenuItem";
            this.SetDimObrazkuToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SetDimObrazkuToolStripMenuItem.Text = "Rozměr obrázku";
            this.SetDimObrazkuToolStripMenuItem.Click += new System.EventHandler(this.SetDimPic);
            // 
            // umísteníPaneluNástojůToolStripMenuItem
            // 
            this.umísteníPaneluNástojůToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vlevoToolStripMenuItem,
            this.vpravoToolStripMenuItem});
            this.umísteníPaneluNástojůToolStripMenuItem.Name = "umísteníPaneluNástojůToolStripMenuItem";
            this.umísteníPaneluNástojůToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.umísteníPaneluNástojůToolStripMenuItem.Text = "Umístení panelu nástojů";
            // 
            // vlevoToolStripMenuItem
            // 
            this.vlevoToolStripMenuItem.Name = "vlevoToolStripMenuItem";
            this.vlevoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vlevoToolStripMenuItem.Text = "Vlevo";
            this.vlevoToolStripMenuItem.Click += new System.EventHandler(this.VlevoToolStripMenuItem_Click);
            // 
            // vpravoToolStripMenuItem
            // 
            this.vpravoToolStripMenuItem.Name = "vpravoToolStripMenuItem";
            this.vpravoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vpravoToolStripMenuItem.Text = "Vpravo";
            this.vpravoToolStripMenuItem.Click += new System.EventHandler(this.VpravoToolStripMenuItem_Click);
            // 
            // filtryToolStripMenuItem
            // 
            this.filtryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.černobílýToolStripMenuItem,
            this.sépieToolStripMenuItem,
            this.negativToolStripMenuItem});
            this.filtryToolStripMenuItem.Name = "filtryToolStripMenuItem";
            this.filtryToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filtryToolStripMenuItem.Text = "Filtry";
            // 
            // černobílýToolStripMenuItem
            // 
            this.černobílýToolStripMenuItem.Name = "černobílýToolStripMenuItem";
            this.černobílýToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.černobílýToolStripMenuItem.Text = "Černobílý";
            this.černobílýToolStripMenuItem.Click += new System.EventHandler(this.CernobilyToolStripMenuItem_Click);
            // 
            // sépieToolStripMenuItem
            // 
            this.sépieToolStripMenuItem.Name = "sépieToolStripMenuItem";
            this.sépieToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sépieToolStripMenuItem.Text = "Sépie";
            this.sépieToolStripMenuItem.Click += new System.EventHandler(this.SepieToolStripMenuItem_Click);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.NegativToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikaciToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.OAplikaciToolStripMenuItem_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(69, 24);
            this.Pic.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Pic.MinimumSize = new System.Drawing.Size(100, 100);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(1301, 725);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Controls.Add(this.currColor);
            this.ColorPanel.Controls.Add(this.Black);
            this.ColorPanel.Controls.Add(this.White);
            this.ColorPanel.Controls.Add(this.Gray);
            this.ColorPanel.Controls.Add(this.Brown);
            this.ColorPanel.Controls.Add(this.Purple);
            this.ColorPanel.Controls.Add(this.Magneta);
            this.ColorPanel.Controls.Add(this.AktualniBarva_Label);
            this.ColorPanel.Controls.Add(this.Blue);
            this.ColorPanel.Controls.Add(this.Green);
            this.ColorPanel.Controls.Add(this.Yellow);
            this.ColorPanel.Controls.Add(this.Orange);
            this.ColorPanel.Controls.Add(this.Red);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorPanel.Location = new System.Drawing.Point(69, 716);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(1301, 33);
            this.ColorPanel.TabIndex = 3;
            // 
            // currColor
            // 
            this.currColor.BackColor = System.Drawing.Color.Black;
            this.currColor.Location = new System.Drawing.Point(95, 3);
            this.currColor.Name = "currColor";
            this.currColor.Size = new System.Drawing.Size(50, 23);
            this.currColor.TabIndex = 17;
            this.currColor.UseVisualStyleBackColor = false;
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.Location = new System.Drawing.Point(500, 3);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(23, 23);
            this.Black.TabIndex = 15;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.White.Location = new System.Drawing.Point(471, 3);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(23, 23);
            this.White.TabIndex = 14;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gray.Location = new System.Drawing.Point(442, 3);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(23, 23);
            this.Gray.TabIndex = 13;
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Brown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brown.Location = new System.Drawing.Point(413, 3);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(23, 23);
            this.Brown.TabIndex = 12;
            this.Brown.UseVisualStyleBackColor = false;
            this.Brown.Click += new System.EventHandler(this.Brown_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purple.Location = new System.Drawing.Point(384, 3);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(23, 23);
            this.Purple.TabIndex = 11;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Magneta
            // 
            this.Magneta.BackColor = System.Drawing.Color.Purple;
            this.Magneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Magneta.Location = new System.Drawing.Point(355, 3);
            this.Magneta.Name = "Magneta";
            this.Magneta.Size = new System.Drawing.Size(23, 23);
            this.Magneta.TabIndex = 10;
            this.Magneta.UseVisualStyleBackColor = false;
            this.Magneta.Click += new System.EventHandler(this.Magneta_Click);
            // 
            // AktualniBarva_Label
            // 
            this.AktualniBarva_Label.AutoSize = true;
            this.AktualniBarva_Label.Location = new System.Drawing.Point(13, 8);
            this.AktualniBarva_Label.Name = "AktualniBarva_Label";
            this.AktualniBarva_Label.Size = new System.Drawing.Size(76, 13);
            this.AktualniBarva_Label.TabIndex = 9;
            this.AktualniBarva_Label.Text = "Vybraná barva";
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.Location = new System.Drawing.Point(326, 3);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(23, 23);
            this.Blue.TabIndex = 8;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.Location = new System.Drawing.Point(297, 3);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(23, 23);
            this.Green.TabIndex = 7;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.Location = new System.Drawing.Point(268, 3);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(23, 23);
            this.Yellow.TabIndex = 6;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orange.Location = new System.Drawing.Point(239, 3);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(23, 23);
            this.Orange.TabIndex = 5;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(210, 3);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(23, 23);
            this.Red.TabIndex = 4;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malování";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnPaint;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnEllipse;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetDimObrazkuToolStripMenuItem;
        private System.Windows.Forms.TrackBar tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Velikost;
        private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem černobílýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sépieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umísteníPaneluNástojůToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vpravoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button currColor;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Magneta;
        private System.Windows.Forms.Label AktualniBarva_Label;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Orange;
    }
}

