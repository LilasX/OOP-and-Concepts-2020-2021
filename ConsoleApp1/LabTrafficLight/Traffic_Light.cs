using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTrafficLight
{
    public partial class Traffic_Light : Form
    {
        int Green_Turn = 0;
        int Yellow_Turn = 0;
        Main_Form form;

        public Traffic_Light()
        {
            InitializeComponent();
            form = new Main_Form();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Green_Turn)
            {
                case 0:
                    form.StartCars();
                    break;
                case 1:
                    form.SlowdownCars();
                    break;
                default:
                    form.StopCars();
                    break;
            }
            // 0(x2) = Green, 1(x2) = Yellow, 2(x2) = Red
            this.pictureGreen.Visible = (Green_Turn == 0) ? true : false;
            Green_Turn = (Green_Turn + 1) % 3;

            this.pictureYellow.Visible = (Yellow_Turn == 1) ? true : false;
            Yellow_Turn = (Yellow_Turn + 1) % 3;


        }

       
        private void pictureGreen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
