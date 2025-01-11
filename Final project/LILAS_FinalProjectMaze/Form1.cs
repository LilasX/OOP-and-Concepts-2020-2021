using FinalProjectMaze.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectMaze.Classes;
using FinalProjectMaze.Classes.Entities;

namespace FinalProjectMaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameManager.Start_Game();
            this.pictureBox1.Width = Map.Max_columns * Map.Tile_size;
            this.pictureBox1.Height = Map.Max_rows * Map.Tile_size;

            int width = Map.Max_columns * Map.Tile_size;
            int height = Map.Max_rows * Map.Tile_size + (this.pictureBox1.Location.Y);
            this.ClientSize = new Size(width, height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (AbstractEntity obj in Map.matrix_entities)
            {
                obj.Draw(e.Graphics);
            }
            GameManager.bird.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool moving = true;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    GameManager.bird.Current_Direction = Direction.UP;
                    break;
                case Keys.Down:
                case Keys.S:
                    GameManager.bird.Current_Direction = Direction.DOWN;
                    break;
                case Keys.Left:
                case Keys.A:
                    GameManager.bird.Current_Direction = Direction.LEFT;
                    break;
                case Keys.Right:
                case Keys.D:
                    GameManager.bird.Current_Direction = Direction.RIGHT;
                    break;
                default:
                    moving = false;
                    break;
            }
            if (moving)
            {
                GameManager.bird.Move();
            }
            this.Refresh();
        }
    }
}
