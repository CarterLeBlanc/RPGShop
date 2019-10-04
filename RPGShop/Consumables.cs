using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Consumables : Item
    {
        public Consumables(string consumableName, int consumableValue, string consumableDescription)
        {
            _name = consumableName;
            _value = consumableValue;
            _description = consumableDescription;
        }
    }
}
