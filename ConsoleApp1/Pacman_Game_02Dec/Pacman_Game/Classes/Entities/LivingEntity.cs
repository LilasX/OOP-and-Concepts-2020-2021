using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public abstract class LivingEntity: AbstractEntity
    {
        private Direction current_Direction;
        public Direction Current_Direction { get => current_Direction; set => current_Direction = value; }

        public LivingEntity(int row, int column):base(0, row, column)
        {

        }
        public abstract void Move();
        public abstract void Eat(AbstractEntity entity);
    }
}
