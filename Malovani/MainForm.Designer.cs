namespace EasyImgEdit
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.button_Text = new System.Windows.Forms.Button();
            this.silaPera = new System.Windows.Forms.Label();
            this.pera = new System.Windows.Forms.Label();
            this.Velikost = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TrackBar();
            this.button_Color = new System.Windows.Forms.Button();
            this.button_Fill = new System.Windows.Forms.Button();
            this.button_Line = new System.Windows.Forms.Button();
            this.button_Rect = new System.Windows.Forms.Button();
            this.buttonElipse = new System.Windows.Forms.Button();
            this.button_Rubb = new System.Windows.Forms.Button();
            this.button_Pencil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetDimObrazkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umísteníPaneluNástojůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vpravoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jazykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.černobílýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sépieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napovedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.pozicelabel2 = new System.Windows.Forms.Label();
            this.labelPozice = new System.Windows.Forms.Label();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PBox = new System.Windows.Forms.PictureBox();
            this.ToolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToolPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToolPanel.Controls.Add(this.button_Text);
            this.ToolPanel.Controls.Add(this.silaPera);
            this.ToolPanel.Controls.Add(this.pera);
            this.ToolPanel.Controls.Add(this.Velikost);
            this.ToolPanel.Controls.Add(this.tb);
            this.ToolPanel.Controls.Add(this.button_Fill);
            this.ToolPanel.Controls.Add(this.button_Line);
            this.ToolPanel.Controls.Add(this.button_Rect);
            this.ToolPanel.Controls.Add(this.buttonElipse);
            this.ToolPanel.Controls.Add(this.button_Rubb);
            this.ToolPanel.Controls.Add(this.button_Pencil);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(0, 24);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(48, 725);
            this.ToolPanel.TabIndex = 0;
            // 
            // button_Text
            // 
            this.button_Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Text.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Text.FlatAppearance.BorderSize = 0;
            this.button_Text.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Text.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Text.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Text.ForeColor = System.Drawing.Color.Black;
            this.button_Text.Location = new System.Drawing.Point(5, 288);
            this.button_Text.Name = "button_Text";
            this.button_Text.Size = new System.Drawing.Size(32, 37);
            this.button_Text.TabIndex = 11;
            this.button_Text.Text = "A";
            this.toolTip1.SetToolTip(this.button_Text, "Vyskreslení textu");
            this.button_Text.UseVisualStyleBackColor = true;
            this.button_Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // silaPera
            // 
            this.silaPera.AutoSize = true;
            this.silaPera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.silaPera.Location = new System.Drawing.Point(11, 399);
            this.silaPera.Name = "silaPera";
            this.silaPera.Size = new System.Drawing.Size(17, 17);
            this.silaPera.TabIndex = 10;
            this.silaPera.Text = "1";
            // 
            // pera
            // 
            this.pera.AutoSize = true;
            this.pera.Location = new System.Drawing.Point(8, 382);
            this.pera.Name = "pera";
            this.pera.Size = new System.Drawing.Size(31, 13);
            this.pera.TabIndex = 9;
            this.pera.Text = "pera:";
            // 
            // Velikost
            // 
            this.Velikost.AutoSize = true;
            this.Velikost.Location = new System.Drawing.Point(8, 369);
            this.Velikost.Name = "Velikost";
            this.Velikost.Size = new System.Drawing.Size(26, 13);
            this.Velikost.TabIndex = 7;
            this.Velikost.Text = "Síla";
            // 
            // tb
            // 
            this.tb.AutoSize = false;
            this.tb.Location = new System.Drawing.Point(1, 419);
            this.tb.Maximum = 25;
            this.tb.Minimum = 1;
            this.tb.Name = "tb";
            this.tb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb.Size = new System.Drawing.Size(35, 197);
            this.tb.TabIndex = 5;
            this.tb.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.toolTip1.SetToolTip(this.tb, "Nastaví tlouštku čáry");
            this.tb.Value = 1;
            this.tb.ValueChanged += new System.EventHandler(this.Tb_ValueChanged);
            // 
            // button_Color
            // 
            this.button_Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Color.BackgroundImage")));
            this.button_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Color.FlatAppearance.BorderSize = 0;
            this.button_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Color.ForeColor = System.Drawing.Color.Transparent;
            this.button_Color.Location = new System.Drawing.Point(220, 2);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(25, 25);
            this.button_Color.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_Color, "Otevře okno pro výběr barvy.");
            this.button_Color.UseVisualStyleBackColor = true;
            this.button_Color.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button_Fill
            // 
            this.button_Fill.BackColor = System.Drawing.Color.Transparent;
            this.button_Fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Fill.BackgroundImage")));
            this.button_Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Fill.FlatAppearance.BorderSize = 0;
            this.button_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fill.ForeColor = System.Drawing.Color.Transparent;
            this.button_Fill.Location = new System.Drawing.Point(3, 250);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(35, 35);
            this.button_Fill.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_Fill, "Výplň barvou");
            this.button_Fill.UseVisualStyleBackColor = false;
            this.button_Fill.Click += new System.EventHandler(this.Filler_Click);
            // 
            // button_Line
            // 
            this.button_Line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Line.BackgroundImage")));
            this.button_Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Line.FlatAppearance.BorderSize = 0;
            this.button_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Line.ForeColor = System.Drawing.Color.Transparent;
            this.button_Line.Location = new System.Drawing.Point(3, 127);
            this.button_Line.Name = "button_Line";
            this.button_Line.Size = new System.Drawing.Size(35, 35);
            this.button_Line.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_Line, "Kreslení čáry");
            this.button_Line.UseVisualStyleBackColor = true;
            this.button_Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // button_Rect
            // 
            this.button_Rect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Rect.BackgroundImage")));
            this.button_Rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Rect.FlatAppearance.BorderSize = 0;
            this.button_Rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rect.ForeColor = System.Drawing.Color.Transparent;
            this.button_Rect.Location = new System.Drawing.Point(3, 209);
            this.button_Rect.Name = "button_Rect";
            this.button_Rect.Size = new System.Drawing.Size(35, 35);
            this.button_Rect.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_Rect, "Kreslení obdélníku");
            this.button_Rect.UseVisualStyleBackColor = true;
            this.button_Rect.Click += new System.EventHandler(this.Rect_Click);
            // 
            // buttonElipse
            // 
            this.buttonElipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonElipse.BackgroundImage")));
            this.buttonElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonElipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonElipse.FlatAppearance.BorderSize = 0;
            this.buttonElipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonElipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonElipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElipse.ForeColor = System.Drawing.Color.Transparent;
            this.buttonElipse.Location = new System.Drawing.Point(3, 168);
            this.buttonElipse.Name = "buttonElipse";
            this.buttonElipse.Size = new System.Drawing.Size(35, 35);
            this.buttonElipse.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonElipse, "Kreslení elispy");
            this.buttonElipse.UseVisualStyleBackColor = true;
            this.buttonElipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // button_Rubb
            // 
            this.button_Rubb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Rubb.BackgroundImage")));
            this.button_Rubb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Rubb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Rubb.FlatAppearance.BorderSize = 0;
            this.button_Rubb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Rubb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Rubb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rubb.ForeColor = System.Drawing.Color.Transparent;
            this.button_Rubb.Location = new System.Drawing.Point(3, 86);
            this.button_Rubb.Name = "button_Rubb";
            this.button_Rubb.Size = new System.Drawing.Size(35, 35);
            this.button_Rubb.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Rubb, "Guma");
            this.button_Rubb.UseVisualStyleBackColor = true;
            this.button_Rubb.Click += new System.EventHandler(this.Rubb_Click);
            // 
            // button_Pencil
            // 
            this.button_Pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Pencil.BackgroundImage")));
            this.button_Pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Pencil.FlatAppearance.BorderSize = 0;
            this.button_Pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pencil.ForeColor = System.Drawing.Color.Transparent;
            this.button_Pencil.Location = new System.Drawing.Point(3, 45);
            this.button_Pencil.Name = "button_Pencil";
            this.button_Pencil.Size = new System.Drawing.Size(35, 35);
            this.button_Pencil.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_Pencil, "Kreslení tužkou");
            this.button_Pencil.UseVisualStyleBackColor = true;
            this.button_Pencil.Click += new System.EventHandler(this.Pen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.nastaveníToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.napovedaToolStripMenuItem});
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
            this.BackToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            this.souborToolStripMenuItem.DropDownOpened += new System.EventHandler(this.SouborToolStripMenuItem_DropDownOpened);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.NewToolStripMenuItem.Text = "Nový";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.BackToolStripMenuItem.Text = "Zpět";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.ZpetToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.OpenToolStripMenuItem.Text = "Otevřít";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveToolStripMenuItem.Text = "Uložit";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.KonecToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetDimObrazkuToolStripMenuItem,
            this.umísteníPaneluNástojůToolStripMenuItem,
            this.jazykToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // SetDimObrazkuToolStripMenuItem
            // 
            this.SetDimObrazkuToolStripMenuItem.Name = "SetDimObrazkuToolStripMenuItem";
            this.SetDimObrazkuToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.SetDimObrazkuToolStripMenuItem.Text = "Rozměr obrázku";
            this.SetDimObrazkuToolStripMenuItem.Click += new System.EventHandler(this.SetDimPic);
            // 
            // umísteníPaneluNástojůToolStripMenuItem
            // 
            this.umísteníPaneluNástojůToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vlevoToolStripMenuItem,
            this.vpravoToolStripMenuItem});
            this.umísteníPaneluNástojůToolStripMenuItem.Name = "umísteníPaneluNástojůToolStripMenuItem";
            this.umísteníPaneluNástojůToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.umísteníPaneluNástojůToolStripMenuItem.Text = "Umístění panelu nástrojů";
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
            // jazykToolStripMenuItem
            // 
            this.jazykToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czToolStripMenuItem,
            this.enToolStripMenuItem});
            this.jazykToolStripMenuItem.Name = "jazykToolStripMenuItem";
            this.jazykToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.jazykToolStripMenuItem.Text = "Jazyk";
            // 
            // czToolStripMenuItem
            // 
            this.czToolStripMenuItem.Name = "czToolStripMenuItem";
            this.czToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.czToolStripMenuItem.Text = "Čeština";
            this.czToolStripMenuItem.Click += new System.EventHandler(this.CzToolStripMenuItem_Click);
            // 
            // enToolStripMenuItem
            // 
            this.enToolStripMenuItem.Name = "enToolStripMenuItem";
            this.enToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.enToolStripMenuItem.Text = "Angličtina";
            this.enToolStripMenuItem.Click += new System.EventHandler(this.EngToolStripMenuItem_Click);
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
            // napovedaToolStripMenuItem
            // 
            this.napovedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikaciToolStripMenuItem});
            this.napovedaToolStripMenuItem.Name = "napovedaToolStripMenuItem";
            this.napovedaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.napovedaToolStripMenuItem.Text = "Nápověda";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.OAplikaciToolStripMenuItem_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Controls.Add(this.pozicelabel2);
            this.ColorPanel.Controls.Add(this.labelPozice);
            this.ColorPanel.Controls.Add(this.currColor);
            this.ColorPanel.Controls.Add(this.Black);
            this.ColorPanel.Controls.Add(this.White);
            this.ColorPanel.Controls.Add(this.button_Color);
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
            this.ColorPanel.Location = new System.Drawing.Point(48, 716);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(1322, 33);
            this.ColorPanel.TabIndex = 3;
            // 
            // pozicelabel2
            // 
            this.pozicelabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pozicelabel2.AutoSize = true;
            this.pozicelabel2.Location = new System.Drawing.Point(1102, 8);
            this.pozicelabel2.Name = "pozicelabel2";
            this.pozicelabel2.Size = new System.Drawing.Size(80, 13);
            this.pozicelabel2.TabIndex = 19;
            this.pozicelabel2.Text = "Pozice kurzoru:";
            // 
            // labelPozice
            // 
            this.labelPozice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPozice.AutoSize = true;
            this.labelPozice.Location = new System.Drawing.Point(1188, 8);
            this.labelPozice.Name = "labelPozice";
            this.labelPozice.Size = new System.Drawing.Size(39, 13);
            this.labelPozice.TabIndex = 18;
            this.labelPozice.Text = "Pozice";
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
            this.Black.Location = new System.Drawing.Point(541, 3);
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
            this.White.Location = new System.Drawing.Point(512, 3);
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
            this.Gray.Location = new System.Drawing.Point(483, 3);
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
            this.Brown.Location = new System.Drawing.Point(454, 3);
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
            this.Purple.Location = new System.Drawing.Point(425, 3);
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
            this.Magneta.Location = new System.Drawing.Point(396, 3);
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
            this.AktualniBarva_Label.Size = new System.Drawing.Size(79, 13);
            this.AktualniBarva_Label.TabIndex = 9;
            this.AktualniBarva_Label.Text = "Vybraná barva:";
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.Location = new System.Drawing.Point(367, 3);
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
            this.Green.Location = new System.Drawing.Point(338, 3);
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
            this.Yellow.Location = new System.Drawing.Point(309, 3);
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
            this.Orange.Location = new System.Drawing.Point(280, 3);
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
            this.Red.Location = new System.Drawing.Point(251, 3);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(23, 23);
            this.Red.TabIndex = 4;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // PBox
            // 
            this.PBox.BackColor = System.Drawing.Color.White;
            this.PBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PBox.Location = new System.Drawing.Point(48, 24);
            this.PBox.MaximumSize = new System.Drawing.Size(3000, 2000);
            this.PBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(1301, 725);
            this.PBox.TabIndex = 1;
            this.PBox.TabStop = false;
            this.PBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PBox_Draw);
            this.PBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.PBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBox_MouseDown);
            this.PBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBox_MouseMove);
            this.PBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PBox);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyImgEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.Button button_Line;
        private System.Windows.Forms.Button button_Rect;
        private System.Windows.Forms.Button buttonElipse;
        private System.Windows.Forms.Button button_Rubb;
        private System.Windows.Forms.Button button_Pencil;
        private System.Windows.Forms.PictureBox PBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napovedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetDimObrazkuToolStripMenuItem;
        private System.Windows.Forms.TrackBar tb;
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label pera;
        private System.Windows.Forms.Label silaPera;
        private System.Windows.Forms.Button button_Text;
        private System.Windows.Forms.Label labelPozice;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jazykToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.Label pozicelabel2;
    }
}

