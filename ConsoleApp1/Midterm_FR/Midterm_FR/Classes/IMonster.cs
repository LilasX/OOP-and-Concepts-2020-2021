using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_FR.classes
{
    public interface IMonster
    {
        void ReceiveDamage(int damage);
        void Attack(Monster target);
    }
}
