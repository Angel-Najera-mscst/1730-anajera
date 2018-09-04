using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotdogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotdogs.Text)
                ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
               5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");
            txtPretaxtotal.Text = (
              Convert.ToDecimal(txtHamburgersSubtotal.Text) + Convert.ToDecimal(txtHotdogsSubtotal.Text)
               ).ToString("0.00");
            txtTax.Text = (
                0.0687m * Convert.ToDecimal(txtPretaxtotal.Text)
               ).ToString("0.00");
            txtTotal.Text = (
                Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxtotal.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotdogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotdogs.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFoodTruck_Load(object sender, EventArgs e)
        {

        }
    }
}
