using System;
using System.Drawing;
using System.Windows.Forms;

namespace Malovani
{
    public partial class InputFormString : Form
    {
        public InputFormString()
        {
            InitializeComponent();
            comboBoxFont.SelectedIndex = 0;
            comboBoxSize.SelectedIndex = 0;

        }
        public Font Font1 { get; set; }
        public string Text1 { get; set; }

        private void Button1_Click(object sender, EventArgs e)
        {

            Text1 = textBox.Text;
            string font = comboBoxFont.Text;
            string fontsizeT = comboBoxSize.Text;
            float fontsize = float.Parse(fontsizeT);

            Font1 = new Font(font, fontsize);
        }

    }
}
