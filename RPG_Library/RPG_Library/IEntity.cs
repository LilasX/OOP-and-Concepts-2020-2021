using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Library
{
    public interface IEntity
    {
        bool IsDead();
        void Receive_Damage(int damage);
        void Attack();
    }
}
