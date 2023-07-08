using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Stack<int> valueStack = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            int value = 1;
            txtDesplay.Text += value;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            int value = 2;
            txtDesplay.Text += value;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int value = 3;
            txtDesplay.Text += value;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int value = 4;
            txtDesplay.Text += value;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int value = 5;
            txtDesplay.Text += value;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int value = 6;
            txtDesplay.Text += value;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int value = 7;
            txtDesplay.Text += value;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int value = 8;
            txtDesplay.Text += value;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int value = 9;
            txtDesplay.Text += value;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int value = 0;
            txtDesplay.Text += value;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

            int numberToAdd;

            if (int.TryParse(txtDesplay.Text, out numberToAdd))
            {
                
                if (valueStack.Count != 0)
                {
                   
                    int firstValue = valueStack.Peek();
                    int sum = numberToAdd + firstValue;
                    txtDesplay.Text = sum.ToString();
                    addValueToStack(sum);
                    txtDesplay.Clear();

                }
                else
                {
                    addValueToStack(numberToAdd);
                    txtDesplay.Clear();
                }
                StackValueCheck();
               
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private int addValueToStack(int value)
        {
            valueStack.Push(value);
            int success = 1;
            return success;
        }

        private void StackValueCheck()
        {
            int firstValue = valueStack.Peek();
            txtHistory.Text = firstValue.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHistory.Clear();
            valueStack.Clear();
            
        }
    }
}
