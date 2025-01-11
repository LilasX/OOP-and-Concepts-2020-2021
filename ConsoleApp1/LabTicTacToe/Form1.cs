using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTicTacToe
{
    public partial class Form1 : Form
    {
        int xTurn = 0;
        bool winner = false;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameClick(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (button.Text == "" && !winner)
            {
                button.Text = (xTurn == 0) ? "X" : "O";
                button.ForeColor = (xTurn == 0) ? Color.Blue : Color.Red;
                xTurn = (xTurn + 1) % 2;
                counter++;
                winner = Is_Winner();
                if (winner)
                {
                    MessageBox.Show("The player " + button.Text + " is the winner!");
                }
                if (!winner && counter == 9)
                    {
                        MessageBox.Show("DRAW !");
                    }
                
            }
            
        }
        private bool Is_Winner()
        {
            if (A1.Text == A2.Text && A2.Text == A3.Text && A3.Text != "")
            {
                return true;
            }
            if (B1.Text == B2.Text && B2.Text == B3.Text && B3.Text != "")
            {
                return true;
            }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C3.Text != "")
            {
                return true;
            }
            if (A1.Text == B1.Text && B1.Text == C1.Text && C1.Text != "")
            {
                return true;
            }
            if (A2.Text == B2.Text && B2.Text == C2.Text && C2.Text != "")
            {
                return true;
            }
            if (A3.Text == B3.Text && B3.Text == C3.Text && C3.Text != "")
            {
                return true;
            }
            if (A1.Text == B2.Text && B2.Text == C3.Text && C3.Text != "")
            {
                return true;
            }
            if (C1.Text == B2.Text && B2.Text == A3.Text && A3.Text != "")
            {
                return true;
            }
            return false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            xTurn = 0;
            counter = 0;
            winner = false;
            
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Text = "";
                }
            }
        }
    }
}
