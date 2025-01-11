using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Classes
{
    public interface IEntity
    {
        bool IsDead();
        void Receive_Damage(int damage);
        void Attack();
    }
}
