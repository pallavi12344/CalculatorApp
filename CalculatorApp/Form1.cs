using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          txtDisplay.Text += "1";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        double FirstNumber, SecondNumber, Result;
        string Operation;
        private void btnAdd_Click(object sender, EventArgs e)
        {
           FirstNumber=double.Parse(txtDisplay.Text) ;
            Operation = "+";
            txtDisplay.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber=double.Parse(txtDisplay.Text);
            Operation = "-";
            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(txtDisplay.Text);
            Operation = "*";
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber=double.Parse(txtDisplay.Text);
            Operation = "/";
            txtDisplay.Clear();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);//Removes the last digit
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            SecondNumber=double.Parse(txtDisplay.Text);

            switch(Operation)
            {
                case "+": Result = FirstNumber + SecondNumber;break;
                case "-": Result = FirstNumber - SecondNumber; break;
                case "*": Result = FirstNumber * SecondNumber; break;
                case "/": Result = FirstNumber / SecondNumber; break;

            }
            txtDisplay.Text = Result.ToString();

        }
        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Back && txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                e.SuppressKeyPress = true;
            }
        }
        
    }
}
