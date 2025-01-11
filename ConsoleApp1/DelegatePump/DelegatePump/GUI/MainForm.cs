using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegatePump.BUSINESS;


namespace DelegatePump.GUI
{
    public partial class MainForm : Form
    {
        static CoreTempMonitor1 controller1 = new CoreTempMonitor1();
        static CoreTempMonitor2 controller2 = new CoreTempMonitor2();
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox_ID.Text.Trim());
            Pump newPump;

            if (this.comboBoxType.SelectedIndex == 0) {
                newPump = new ElectricPumpDriver(id);
                //Add the pump to the controller list
                controller1.Add(newPump);
                this.listBox1.Items.Add("Electric Pump " + id);
            }else
            if (this.comboBoxType.SelectedIndex == 1)
            {
                newPump = new HydrolicPumpDriver(id);
                //Add the pump to the controller list
                controller1.Add(newPump);
                this.listBox1.Items.Add("Hydrolic Pump " + id);
            } else
            if (this.comboBoxType.SelectedIndex == 2)
            {
                newPump = new PneumaticPumpDriver(id);
                //Add the pump to the controller list
                controller1.Add(newPump);
                this.listBox1.Items.Add("Pneumatic Pump " + id);
            }
            
        }

        private void buttonOn1_Click(object sender, EventArgs e)
        {
            string result = controller1.switchOnAllPumps();
            this.textBox1.Text = result;
        }

        private void buttonAddDelegate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox_ID.Text.Trim());
            StartPumpCall newPumpDelegate;
           

             if (this.comboBoxType.SelectedIndex == 0) {
                ElectricPumpDriver newPump = new ElectricPumpDriver(id);
                newPumpDelegate = new StartPumpCall(newPump.StartPumpRunning);
                //Add the pump delegate to the controller list
                controller2.Add(newPumpDelegate);
                this.listBox2.Items.Add("Electric Pump Delegate " + id);
            }else
            if (this.comboBoxType.SelectedIndex == 1)
            {
                HydrolicPumpDriver newPump = new HydrolicPumpDriver(id);
                newPumpDelegate = new StartPumpCall(newPump.TurnON);
                //Add the pump delegate to the controller list
                controller2.Add(newPumpDelegate);
                this.listBox2.Items.Add("Hydrolic Pump Delegate " + id);
            }else
             if (this.comboBoxType.SelectedIndex == 2)
             {
                 PneumaticPumpDriver newPump = new PneumaticPumpDriver(id);
                 newPumpDelegate = new StartPumpCall(newPump.SwitchOn);
                 //Add the pump to the controller list
                 controller2.Add(newPumpDelegate);
                 this.listBox2.Items.Add("Pneumatic Pump Delegate " + id);
             }
        }

        private void buttonOn2_Click(object sender, EventArgs e)
        {
            string result = controller2.switchOnAllPumps();
            this.textBox2.Text = result;
        }
    }
}
