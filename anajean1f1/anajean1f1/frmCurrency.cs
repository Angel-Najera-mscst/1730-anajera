﻿using System;
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
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnEurope.BackgroundImage = picEurope.Image;
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
        }
    }
}
