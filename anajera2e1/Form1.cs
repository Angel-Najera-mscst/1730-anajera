using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera2e1
{
    public partial class Form1 : Form
    {
        private object input07aTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            result04TextBox.Text = "";
            result04cTextBox.Text = "";
            result05TextBox.Text = "";
            result05bTextBox.Text = "";
            result06TextBox.Text = "";
            result06bTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09aTextBox.Text = "";
            result09bTextBox.Text = "";

            //1
            decimal subtotal = Convert.ToDecimal(input01TextBox.Text);
            result01TextBox.Text = (subtotal>= 250 && subtotal < 500).ToString();

            //2
            int timeInService = Convert.ToInt32(input02TextBox.Text);
            result02TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();

            //3
            bool isValid = Convert.ToBoolean(input03aTextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);

            int counter = Convert.ToInt32(input03bTextBox.Text);
            result03TextBox.Text = (isValid == true & counter++ < years).ToString();
            result03bTextBox.Text = counter.ToString();

            //4
            counter = Convert.ToInt32(input03bTextBox.Text);
            result04TextBox.Text = (isValid == true & counter++ < years).ToString();
            result04cTextBox.Text = counter.ToString();

            //5
            counter = Convert.ToInt32(input03bTextBox.Text);
            result05TextBox.Text = (isValid == true || counter++ < years).ToString();
            result05bTextBox.Text = counter.ToString();

            //6
            counter = Convert.ToInt32(input03bTextBox.Text);
            result06TextBox.Text = (isValid == true | counter++ < years).ToString();
            result06bTextBox.Text = counter.ToString();

            //7
            DateTime startDate = Convert.ToDateTime(input7aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input7bTextBox.Text);
            DateTime date = Convert.ToDateTime(input7cTextBox.Text);
            isValid = Convert.ToBoolean(input7dTextBox.Text);
            result07TextBox.Text = (
                date > startDate && date < expirationDate || isValid == true
                ).ToString();

            //8
            decimal thisYTD = Convert.ToDecimal(input8aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input8bTextBox.Text);
            string empType = input8cTextBox.Text;
            int startYear = Convert.ToInt32(input8dTextBox.Text);
            int currentYear = Convert.ToInt32(input8eTextBox.Text);
            result08TextBox.Text = (
                ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
                ).ToString();
            //9 
            counter = Convert.ToInt32(input9aTextBox.Text);
            years = Convert.ToInt32(input9bTextBox.Text);
            result09aTextBox.Text = (
                !(counter++ >= years)
                ).ToString();
        }
    }
}
