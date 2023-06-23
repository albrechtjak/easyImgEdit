
namespace Malovani
{
    partial class InputDim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmVyska = new System.Windows.Forms.NumericUpDown();
            this.nmSirka = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmVyska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSirka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Výška";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šířka";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(125, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Změna rozměrů smaže obrázek! Zadávejte celá čisla v pixelech.";
            // 
            // nmVyska
            // 
            this.nmVyska.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmVyska.Location = new System.Drawing.Point(146, 50);
            this.nmVyska.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmVyska.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmVyska.Name = "nmVyska";
            this.nmVyska.Size = new System.Drawing.Size(69, 20);
            this.nmVyska.TabIndex = 6;
            this.nmVyska.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nmSirka
            // 
            this.nmSirka.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmSirka.Location = new System.Drawing.Point(146, 76);
            this.nmSirka.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmSirka.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmSirka.Name = "nmSirka";
            this.nmSirka.Size = new System.Drawing.Size(69, 20);
            this.nmSirka.TabIndex = 7;
            this.nmSirka.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // InputDim
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 155);
            this.Controls.Add(this.nmSirka);
            this.Controls.Add(this.nmVyska);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputDim";
            this.Text = "Změna rozměru";
            ((System.ComponentModel.ISupportInitialize)(this.nmVyska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSirka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmVyska;
        private System.Windows.Forms.NumericUpDown nmSirka;
    }
}