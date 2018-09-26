using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera1e2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttest1.Text = "0";
            txttest2.Text = "0";
            txttest3.Text = "0";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            txtaverage.Text = (
                        Convert.ToDecimal(txttest1.Text) + Convert.ToDecimal(txttest2.Text) + Convert.ToDecimal(txttest3) / 3m).ToString("0.00");
        }
    }
}