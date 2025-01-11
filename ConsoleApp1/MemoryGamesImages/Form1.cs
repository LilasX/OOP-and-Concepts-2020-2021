using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGamesImages
{
    public partial class Form1 : Form
    {
        
        private List<string> imageList;
        private SortedList<string, string> dictionary;
        private string path = "../../images/";
        private string default_image = "Question_icon.png";
        private static Random random = new Random();

        private static int counter_good_answers = 0;
        private static int counter_tries = 10;
        private Label first_label;
        private Label second_label;

        public Form1()
        {
            InitializeComponent();
            AssignIcons();
            this.Text = "Number of tries = " + counter_tries;
        }

        public void AssignIcons()
        {
            first_label = null;
            second_label = null;

            this.imageList = new List<string>();
            imageList = new List<string>();
            imageList.Add("cow-face-icon.png");
            imageList.Add("dog-face-icon.png");
            imageList.Add("fox-face-icon.png");
            imageList.Add("koala-icon.png");
            imageList.Add("lion-face-icon.png");
            imageList.Add("monkey-face-icon.png");
            imageList.Add("panda-face-icon.png");
            imageList.Add("wolf-face-icon.png");

            //Duplicates

            imageList.Add("cow-face-icon.png");
            imageList.Add("dog-face-icon.png");
            imageList.Add("fox-face-icon.png");
            imageList.Add("koala-icon.png");
            imageList.Add("lion-face-icon.png");
            imageList.Add("monkey-face-icon.png");
            imageList.Add("panda-face-icon.png");
            imageList.Add("wolf-face-icon.png");

            this.dictionary = new SortedList<string, string>();

            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                int random_index = random.Next(0, imageList.Count);
                string image_name = this.imageList[random_index];
                string label_name = control.Name;

                imageList.RemoveAt(random_index);
                this.dictionary.Add(control.Name, image_name);


            }


        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string label_name = label.Name;
            string image_name = dictionary[label_name];

            Image image = Image.FromFile(path + image_name);
            label.Image = image;

            if(first_label == null)
            {
                first_label = label;

            }
            else
            {
                if (second_label == null)
                {
                    second_label = label;
                    MouseClickMessageFilter.DisableMouseClicks();
                    timer1.Start();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string label_name1 = first_label.Name;
            string image1 = this.dictionary[label_name1];
            string label_name2 = second_label.Name;
            string image2 = this.dictionary[label_name2];

            if (image1 != image2)
            {
                Image image = Image.FromFile(path + default_image);
                first_label.Image = image;
                second_label.Image = image;
                counter_tries--;
                this.Text = "Number of tries = " + counter_tries;
            }
            else
            {
                counter_good_answers++; 
            }
            this.timer1.Stop();
            MouseClickMessageFilter.EnableMouseClicks();
            this.first_label= null;
            this.second_label = null;
            if(IsWinner())
            {
                MessageBox.Show("You are winner ! Congratulations !");

            }
            else
            {
                if (GameOver())
                {
                    MessageBox.Show("Game Over !");
                    MouseClickMessageFilter.DisableMouseClicks();
                }
            }

        }

        public bool IsWinner()
        {
            if(counter_good_answers == 8)
            {
                return true;
            }
            return false;
        }

        public bool GameOver()
        {
            if (counter_tries <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
