using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cm = this.txtHeight.Text;
            string kg = this.txtWeight.Text;

            if (cm == "" && kg == "")
            {
                MessageBox.Show("Invalid Values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                double height = Convert.ToDouble(cm);
                double weight = Convert.ToDouble(kg);

                double height2m = (height * height) / 100;
                double BMI = weight / height2m;
                string bmi = Convert.ToString(BMI);

                if (BMI > 0 && BMI < 18.5)
                {
                    MessageBox.Show("BMI : " + bmi + "\nSignification : Underweight \nRisk of developing health problems : High risk", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (BMI >= 18.5 && BMI < 25)
                {
                    MessageBox.Show("BMI : " + bmi + "\nSignification : Healthy Weight \nRisk of developing health problems : Low risk", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (BMI >= 25 && BMI <= 30)
                {
                    MessageBox.Show("BMI : " + bmi + "\nSignification : Overweight \nRisk of developing health problems : High risk", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (BMI > 30 && BMI < 35)
                {
                    MessageBox.Show("BMI : " + bmi + "\nSignification : Obese \nRisk of developing health problems : Very High risk", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}
