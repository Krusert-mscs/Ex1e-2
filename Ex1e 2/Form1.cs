using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1e_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                (Convert.ToDecimal(txt1.Text) + Convert.ToDecimal(txt2.Text) + Convert.ToDecimal(txt3.Text)) / 3
            ).ToString("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txtAverage.Text = "";
        }
    }
}
