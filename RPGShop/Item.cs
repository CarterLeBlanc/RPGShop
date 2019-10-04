using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Item
    {
        protected int _value;
        protected string _name = "";
        protected string _description = "";

        public int GetValue()
        {
            return _value;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
