using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameLab
{
    public partial class Form1 : Form
    {
        private List<string> icons;
        private Label first_label_clicked;
        private Label second_label_clicked;
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            icons = new List<string>();
            icons.Add("!");
            icons.Add("@");
            icons.Add("B");
            icons.Add("E");
            icons.Add("J");
            icons.Add("%");
            icons.Add("P");
            icons.Add("S");

            //Duplicates
            icons.Add("!");
            icons.Add("@");
            icons.Add("B");
            icons.Add("E");
            icons.Add("J");
            icons.Add("%");
            icons.Add("P");
            icons.Add("S");
        }

        private void AssignIcons()
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    int random_index = random.Next(this.icons.Count);
                    label.Text = icons[random_index];
                    icons.RemoveAt(random_index);
                    label.ForeColor = label.BackColor;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AssignIcons();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (label.ForeColor != Color.Black)
            {
                label.ForeColor = Color.Black;

                if (first_label_clicked == null)
                {
                    first_label_clicked = label;
                }
                else
                {
                    if (second_label_clicked == null)
                    {
                        second_label_clicked = label;
                        timer1.Start();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.first_label_clicked.Text != this.second_label_clicked.Text)
            {
                this.first_label_clicked.ForeColor = this.first_label_clicked.BackColor;
                this.second_label_clicked.ForeColor = this.second_label_clicked.BackColor;
            }
            this.first_label_clicked = null;
            this.second_label_clicked = null;
            this.timer1.Stop();

            if (IsWinner())
            {
                MessageBox.Show("Congratulations! You are winner!");
            }
        }

        private bool IsWinner()
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                Label label = (Label)control;
                if (label.ForeColor == label.BackColor)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
