using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera2d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
        }

        private void setFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1Result.Text = "Fail";
            textBox2Result.Text = "Fail";
            textBox3Result.Text = "Fail";
            textBox4Result.Text = "Fail";
            textBox5Result.Text = "Fail";
            textBox6Result.Text = "Fail";
            textBox7Result.Text = "Fail";
            textBox8Result.Text = "Fail";
            textBox9Result.Text = "Fail";
            textBox10Result.Text = "Fail";

            if (textBox1Input.Text == "Frank")
                textBox1Result.Text = "Success";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3Result.Text = "Success";

            bool val4 = Convert.ToDecimal(textBox4Input.Text);
            if (val4 == false)
                textBox4Result = "Success";

            if (textBox2Input.Text == "")
                textBox2Result.Text = "Success";

            decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
            if (val5A == 2m)
                textBox5Result.Text = "Success";

            decimal val5B = Convert.ToDecimal(textBox5InputB.Text);
            if (val5B == 2m)
                textBox5Result.Text = "Success";

            if (textBox6Input.Text == "xyz")
                textBox6Result.Text = "Success";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 == 1m)
                textBox5Result.Text = "Success";

            decimal val8A = Convert.ToDecimal(textBox8InputA.Text);
            if (val8A == 1m)
                textBox8Result.Text = "Success";

            decimal val8B = Convert.ToDecimal(textBox8InputB.Text);
            if (val8B == 2m)
                textBox8Result.Text = "Success";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 == 500m)
                textBox9Result.Text = "Success";

            decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
            if (val10A == 2m)
                textBox10Result.Text = "Success";

            decimal val10B = Convert.ToDecimal(textBox10InputB.Text);
            if (val10B == 3m)
                textBox10Result.Text = "Success";
        }
    }
}
