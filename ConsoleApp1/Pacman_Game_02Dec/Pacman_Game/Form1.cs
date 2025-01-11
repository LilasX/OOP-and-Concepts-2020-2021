using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pacman_Game.Classes;
using Pacman_Game.Classes.Entities;
using Pacman_Game.Classes.Pathfinding;

namespace Pacman_Game
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            Game_Manager.Start_Game();
            this.pictureBox1.Width  = Map.Max_columns * Map.Tile_size;
            this.pictureBox1.Height = Map.Max_rows * Map.Tile_size;

             int width = Map.Max_columns * Map.Tile_size;
             int height = Map.Max_rows * Map.Tile_size + (this.pictureBox1.Location.Y);
            this.ClientSize = new Size(width, height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(AbstractEntity obj in Map.matrix_entities)
            {
                obj.Draw(e.Graphics);
            }
            Game_Manager.pacman.Draw(e.Graphics);

            foreach(Ghost ghost in Game_Manager.ListGhosts)
            {
                ghost.Draw(e.Graphics);
            }
            this.label_Lives.Text = Game_Manager.pacman.Lives.ToString();
            this.label_Score.Text = Game_Manager.pacman.Score.ToString();
            this.label_Count.Text = Map.Count_Eatable_Entities.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    Game_Manager.pacman.Current_Direction = Direction.UP;
                    this.timer1.Enabled = true;
                    break;
                case Keys.Down:
                case Keys.S:
                    Game_Manager.pacman.Current_Direction = Direction.DOWN;
                    this.timer1.Enabled = true;
                    break;
                case Keys.Left:
                case Keys.A:
                    Game_Manager.pacman.Current_Direction = Direction.LEFT;
                    this.timer1.Enabled = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    Game_Manager.pacman.Current_Direction = Direction.RIGHT;
                    this.timer1.Enabled = true;

                    break;
            }
            this.timer1.Interval = 100;
            this.Refresh();//Call Paint event 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game_Manager.pacman.Move();
            this.Text = "Score = " +Game_Manager.pacman.Score.ToString();

            this.Refresh();//Call Paint event 
        }
    }
}
