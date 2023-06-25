using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyImgEdit
{
    public partial class InputFormString : Form
    {
        public InputFormString()
        {
            InitializeComponent();
            comboBoxFont.SelectedIndex = 0;
            comboBoxSize.SelectedIndex = 0;
            switch (MainForm.langOpt)
            {
                case 1:
                    label3.Text = "Zadejte požadovaný text, font a velikost";
                    label4.Text = "Velikost";
                    break;
                case 2:
                    label3.Text = "Enter the desired text, font and size";
                    label4.Text = "Size";
                    break;
            }



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