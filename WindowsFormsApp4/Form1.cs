using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;
            try
            {
                R1 = Convert.ToDouble(txtbxR1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(txtbxR2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(txtbxR3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(txtbxR4.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R5 = 0;
            }
            

            double Rt = R1 + R2 + R3 + R4 + R5;

            LBLanswer.Text = "total R = " + Rt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
