using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "1";
        }*/

        private void button_Click(object sender, EventArgs e)
        {
            if((Result.Text=="0") || (isOperationPerformed))
            {
                Result.Clear();
            }
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!Result.Text.Contains("."))
                {
                    Result.Text = Result.Text + button.Text;
                }
            }
            else
            {
                Result.Text = Result.Text + button.Text;
            }
            
            isOperationPerformed = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(result !=0)
            {
                buttonEq.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(Result.Text);
                isOperationPerformed = true;
            }
            
            //Result.Text = Result.Text + button.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            result = 0;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            if(operation== "+")
            {
                Result.Text = (result + double.Parse(Result.Text)).ToString();
            }
            else if (operation == "-")
            {
                Result.Text = (result - double.Parse(Result.Text)).ToString();
            }
            else if (operation == "X")
            {
                Result.Text = (result * double.Parse(Result.Text)).ToString();
            }
            else if (operation == "/")
            {
                Result.Text = (result / double.Parse(Result.Text)).ToString();
            }

            result = double.Parse(Result.Text);

        }
    }
}
