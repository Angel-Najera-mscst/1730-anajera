using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera2g2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' with no defult
            resultSwitch01TextBox.Text = Ex2gCalculations.Swich01(input1aTextBox.Text);
            public static string If01(string customerType);

            // 1b) Seperate 'if' statements
            resultif01TextBox.Text = Ex2gCalculations.If01(input1aTextBox.Text);

            // 1c) if elseif
            resultelseif01TextBox.Text = Ex2gCalculations.ElseIf01(input1aTextBox.Text);

            // 1d) nested if-else
            resultNestedifElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1aTextBox.Text);

            //1e) 'Switch' with defult
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwichDefault01(input1aTextBox.Text);
        }
    }
}
