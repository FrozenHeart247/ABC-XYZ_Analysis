using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_XYZ_analysis
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
           // logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            InitializeComponent();
            this.textBoxDescription.Text = "Программа предназначена для проведения ABC, XYZ, ABC-XYZ анализов.";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
