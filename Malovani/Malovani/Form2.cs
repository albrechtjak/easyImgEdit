using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancePaint
{
    public partial class Form2 : Form
    {
        public Form2()
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
                SetHeight = Int32.Parse(h);
                SetWidth = Int32.Parse(w);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadejte prosim cislo");
            }
        }
        
    }
}
