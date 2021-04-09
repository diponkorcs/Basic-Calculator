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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "1";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(Result.Text=="0")
            {
                Result.Clear();
            }
            Button button = (Button)sender;
            Result.Text = Result.Text + button.Text;
        }
    }
}
