using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKK
{
    public partial class Form1 : Form
    {
        double num1, num2, q;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Num_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ",")
                {
                    if (!txtResult.Text.Contains(","))
                       txtResult.Text = txtResult.Text + num.Text;                   
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            num1 = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                case "+":
                    txtResult.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtResult.Text = (num1 - num2).ToString();
                    break;
                case "×":
                    txtResult.Text = (num1 * num2).ToString();
                    break;
                case "÷":
                    txtResult.Text = (num1 / num2).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            string f, s;

            f = Convert.ToString(num1);
            s = Convert.ToString(num2);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
