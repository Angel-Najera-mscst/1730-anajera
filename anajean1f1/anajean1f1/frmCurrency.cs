using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajean1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }
        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtRate.Text = "0.717976";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtRate.Text = "0.0139831";
            txtCurrency.Focus();
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = btnCostaRica.Text + ": ";
            txtRate.Text = "0.0017";
            txtCurrency.Focus();
        }

        private void btnEurope_Click(object sender, EventArgs e)
        {
            btnEurope.BackgroundImage = picEurope.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            lblCurrency.Text = btnEurope.Text + ": ";
            txtRate.Text = "1.15";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
              Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + "+" + txtTotalUSD.Text;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }
    }
}
