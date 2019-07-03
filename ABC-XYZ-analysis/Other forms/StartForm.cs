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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;// progressBar2.ForeColor = Color.Red;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
