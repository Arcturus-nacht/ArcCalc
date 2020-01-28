using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcCalc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_pressed))
                txtResult.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + b.Text;
            }
            else
                txtResult.Text = txtResult.Text + b.Text;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                btnEqu.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                lblSym.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(txtResult.Text);
                operation_pressed = true;
                lblSym.Text = value + " " + operation;
            }
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            
            lblSym.Text = "";
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;

                default:
                    break;


            }//end switch
            value = Double.Parse(txtResult.Text);
            operation = "";
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
            lblSym.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows number and operation entry from the keyboard
            switch(e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case ".":
                    btnDec.PerformClick();
                    break;
                case "+":
                    btnAdd.PerformClick();
                    break;
                case "-":
                    btnSub.PerformClick();
                    break;
                case "*":
                    btnMult.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "=":
                    btnEqu.PerformClick();
                    break;
                case "ENTER":
                    btnEqu.PerformClick();
                    break;
                default:
                    break;


            }
        }
    }
}
