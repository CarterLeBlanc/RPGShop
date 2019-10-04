using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class AttackItem : Item
    {
        public AttackItem(string weaponName, int weaponValue, string weaponDescription)
        {
            _name = weaponName;
            _value = weaponValue;
            _description = weaponDescription;
        }
    }
}
