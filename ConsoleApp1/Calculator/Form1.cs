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
        double variable1 = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            Application.Exit(); //this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear(); //this.textBox1.Text="";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int unicode = 247;
            char character = (char)247;
            this.buttondivision.Text = character.ToString();
        }

        private void ButtonNumberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.textBox1.Text += button.Text;
        }

        private void buttonoperationsclick(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            if(text == "")
            {
                variable1 = 0;
            }
            else
            {
                variable1 = Convert.ToDouble(text);
                this.textBox1.Clear();
            }
            

            Button button = (Button)sender;
            operation = button.Text;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            double variable2 = 0;
            if (text != "" && operation != "")
            {
                variable2 = Convert.ToDouble(text);
                this.textBox1.Clear();
            }
            

            double result = 0;
            switch(operation)
            {
                case "+":
                    result = variable1 + variable2;
                    break;
                case "-":
                    result = variable1 - variable2;
                    break;
                case "x":
                    result = variable1 * variable2;
                    break;
                default:
                    result = (variable2 == 0)? variable1 : variable1 / variable2;
                    break;
            }
            if (operation != "")
            {
                this.textBox1.Text = result.ToString();
            }
          
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "")
            {
                this.textBox1.Text = "0.";
            }
            else
            {
                if (this.textBox1.Text.Contains(".") == false)
                {
                    this.textBox1.Text += ".";
                }
                
                
            }
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            variable1 = Convert.ToDouble(textBox1.Text);
            variable1 = (variable1 == 0) ? 0 : (1 / variable1);
            this.textBox1.Text = variable1.ToString();
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            variable1 = Convert.ToDouble(textBox1.Text);
            variable1 = variable1 / 100;
            this.textBox1.Text = variable1.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.') || (e.KeyChar == '.' && this.textBox1.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
