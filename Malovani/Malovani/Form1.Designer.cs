namespace AdvancePaint
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnEllipse);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 922);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(17, 507);
            this.tb.Maximum = 25;
            this.tb.Minimum = 1;
            this.tb.Name = "tb";
            this.tb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb.Size = new System.Drawing.Size(45, 150);
            this.tb.TabIndex = 5;
            this.tb.Value = 1;
            this.tb.ValueChanged += new System.EventHandler(this.Tb_ValueChanged);
            // 
            // BtnColor
            // 
            this.BtnColor.BackgroundImage = global::AdvancePaint.Properties.Resources.colour;
            this.BtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.Color.White;
            this.BtnColor.Location = new System.Drawing.Point(12, 17);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(50, 50);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnPaint
            // 
            this.BtnPaint.BackColor = System.Drawing.Color.Black;
            this.BtnPaint.BackgroundImage = global::AdvancePaint.Properties.Resources.paint;
            this.BtnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnPaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaint.ForeColor = System.Drawing.Color.White;
            this.BtnPaint.Location = new System.Drawing.Point(12, 438);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(50, 50);
            this.BtnPaint.TabIndex = 5;
            this.BtnPaint.UseVisualStyleBackColor = false;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackgroundImage = global::AdvancePaint.Properties.Resources.line_icon_18_256__1_;
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.Color.White;
            this.BtnLine.Location = new System.Drawing.Point(12, 228);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(50, 50);
            this.BtnLine.TabIndex = 4;
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.BackgroundImage = global::AdvancePaint.Properties.Resources.rounded_rectangle_icon_18_256;
            this.BtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.ForeColor = System.Drawing.Color.White;
            this.BtnRectangle.Location = new System.Drawing.Point(12, 369);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(50, 50);
            this.BtnRectangle.TabIndex = 3;
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.BackgroundImage = global::AdvancePaint.Properties.Resources.Ellipse___Copy;
            this.BtnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllipse.ForeColor = System.Drawing.Color.White;
            this.BtnEllipse.Location = new System.Drawing.Point(12, 298);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(50, 50);
            this.BtnEllipse.TabIndex = 2;
            this.BtnEllipse.UseVisualStyleBackColor = true;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackgroundImage = global::AdvancePaint.Properties.Resources.eraser;
            this.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.Color.White;
            this.BtnEraser.Location = new System.Drawing.Point(12, 160);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(50, 50);
            this.BtnEraser.TabIndex = 1;
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackgroundImage = global::AdvancePaint.Properties.Resources.pencil;
            this.BtnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.Color.White;
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
            this.nápovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewToolStripMenuItem.Text = "Nový";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Otevřít";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Uložit";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetDimObrazkuToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // SetDimObrazkuToolStripMenuItem
            // 
            this.SetDimObrazkuToolStripMenuItem.Name = "SetDimObrazkuToolStripMenuItem";
            this.SetDimObrazkuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.SetDimObrazkuToolStripMenuItem.Text = "Rozměr obrázku";
            this.SetDimObrazkuToolStripMenuItem.Click += new System.EventHandler(this.SetDimPic);
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
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.OAplikaciToolStripMenuItem_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pic.Location = new System.Drawing.Point(82, 27);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(852, 418);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}

