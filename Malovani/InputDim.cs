using System;
using System.Windows.Forms;

namespace Malovani
{
    public partial class InputDim : Form
    {
        public InputDim()
        {
            InitializeComponent();

        }
        public int SetHeight { get; set; }
        public int SetWidth { get; set; }

        private void Button1_Click(object sender, EventArgs e)
        {
            string h = textBoxH.Text;
            string w = textBoxW.Text;

            try
            {
                SetHeight = int.Parse(h);
                SetWidth = int.Parse(w);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadejte prosim cislo");
            }
        }

    }
}
