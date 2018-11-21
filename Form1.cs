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
    public partial class Form1 : Form{
        private double ans;
        private double prevData;
        private double currentData;
        private string operation;
        bool equal = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = "-";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonNine.Text;
            }
            else
            {
                textBoxShow.Text = buttonNine.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonFour.Text;
            }
            else
            {
                textBoxShow.Text = buttonFour.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonFive.Text;
            }
            else
            {
                textBoxShow.Text = buttonFive.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonTwo.Text;
            }
            else
            {
                textBoxShow.Text = buttonTwo.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            prevData = Convert.ToDouble(textBoxShow.Text);
            textBoxShow.Text = "0";
            textBox1.Text = Convert.ToString(prevData) + " - ";
            operation = "minus";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonThree.Text;
            }
            else
            {
                textBoxShow.Text = buttonThree.Text;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation) {
                case "plus":
                    currentData = Convert.ToDouble(textBoxShow.Text);
                    ans = prevData + currentData;
                    textBoxShow.Text = Convert.ToString(ans);
                    ans = 0;
                    prevData = 0;
                    operation = "";
                    equal = true;
                    textBox1.Text = "";
                    break;
                case "minus":
                    currentData = Convert.ToDouble(textBoxShow.Text);
                    ans = prevData - currentData;
                    textBoxShow.Text = Convert.ToString(ans);
                    ans = 0;
                    prevData = 0;
                    operation = "";
                    equal = true;
                    textBox1.Text = "";
                    break;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }

            /*if (operation!="")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/

            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + button0.Text;
            }
            else {
                textBoxShow.Text = button0.Text;
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonOne.Text;
            }
            else
            {
                textBoxShow.Text = buttonOne.Text;
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonSix.Text;
            }
            else
            {
                textBoxShow.Text = buttonSix.Text;
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }*/
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonSeven.Text;
            }
            else
            {
                textBoxShow.Text = buttonSeven.Text;
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            /*if (operation != "")
            {
                textBoxShow.Text = "0";
                operation = " ";
            }
            */
            if (textBoxShow.Text != "0")
            {
                //double prevData = Convert.ToDouble(textBoxShow.Text);
                textBoxShow.Text = textBoxShow.Text + buttonEight.Text;
            }
            else
            {
                textBoxShow.Text = buttonEight.Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            prevData = Convert.ToDouble(textBoxShow.Text);
            textBoxShow.Text = "0";
            textBox1.Text = Convert.ToString(prevData) + " + ";
            operation = "plus";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBoxShow.Text = "0";
                equal = false;
            }
            if (!textBoxShow.Text.Contains('.')) {
                textBoxShow.Text = textBoxShow.Text + ".";
            }
        }

        private void textBoxShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
