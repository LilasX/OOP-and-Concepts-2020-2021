using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            this.txt_kg.Clear();
            this.txt_lbs.Clear();
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            double rate = 2.2046;
            string str_kg = this.txt_kg.Text;
            string str_lbs = this.txt_lbs.Text;

            if (str_kg == "" && str_lbs == "")
            {
                MessageBox.Show("Invalid Values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (str_kg!= "")
                {
                    double kg = Convert.ToDouble(str_kg);
                    double lbs = kg * rate;
                    this.txt_lbs.Text = lbs.ToString();
                }
                else
                {
                    double lbs = Convert.ToDouble(str_lbs);
                    double kg = lbs / rate;
                    this.txt_kg.Text = kg.ToString();
                }
            }
        }

        private void txt_kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.') || (e.KeyChar == '.' && this.txt_kg.Text.IndexOf('.') >-1))
            {
                e.Handled = true;
            }
        }

        private void txt_lbs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.') || (e.KeyChar == '.' && this.txt_lbs.Text.IndexOf('.')>-1))//or == false
            {
                e.Handled = true;
            }
        }
    }
}
