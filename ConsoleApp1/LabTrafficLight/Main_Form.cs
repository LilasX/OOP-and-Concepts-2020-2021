using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTrafficLight.Classes;

namespace LabTrafficLight
{
    public partial class Main_Form : Form
    {

        private List<Car> myCarList;

        public Main_Form()
        {
            InitializeComponent();
            Car myCar = new Car();

            myCarList = new List<Car>();
            myCarList.Add(myCar);
            myCarList.Add(myCar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Form_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < myCarList.Count; i++)
            {
                myCarList[i].Draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Car elements in myCarList)
            {
                elements.Move();
                
            }
            this.Refresh();
        }
        public void StartCars()
        {
            foreach (Car elements in myCarList)
            {
                elements.Start(20);

            }
        }
        public void SlowdownCars()
        {
            foreach (Car elements in myCarList)
            {
                elements.Slowdown();

            }
        }
        public void StopCars()
        {
            foreach (Car elements in myCarList)
            {
                elements.Brake();

            }
        }
    }
}

