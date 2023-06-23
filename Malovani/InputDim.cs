using System;
using System.Windows.Forms;

namespace Malovani
{
    public partial class InputDim : Form
    {
        public InputDim()
        {
            InitializeComponent();
            switch (MainForm.langOpt)
            {
                case 1:
                    this.Text = "Změna rozměrů";
                    label3.Text = "Změna rozměrů smaže obrázek! Zadávejte celá čisla v pixelech.";
                    label1.Text = "Výška";
                    label2.Text = "Šířka";
                    break;
                case 2:
                    this.Text = "Resize picture";
                    label3.Text = "Resizing will delete the image! Enter integers in pixels.";
                    label1.Text = "Height";
                    label2.Text = "Width";
                    break;
            }

        }
        public int SetHeight { get; set; }
        public int SetWidth { get; set; }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetHeight = Convert.ToInt32(nmVyska.Value);
            SetWidth = Convert.ToInt32(nmSirka.Value);
        }

    }
}
