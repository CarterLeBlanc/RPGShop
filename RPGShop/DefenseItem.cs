using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    //Class DefenseItem inherits from Item class
    class DefenseItem : Item
    {
        //Item constructor
        public DefenseItem(string armourName, int armourValue, string armourDescription)
        {
            _name = armourName;
            _value = armourValue;
            _description = armourDescription;
        }
    }
}
