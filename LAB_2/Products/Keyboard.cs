using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1.Products
{
    public class Keyboard : Periphery
    {
        private string _switch;

        public string Switch
        {
            get { return _switch; }
            set { _switch = value; }
        }

        public Keyboard() { Switch = "noname"; }
        public Keyboard(string Name, decimal Price, bool Backlit, string Switch) : base(Name, Price, Backlit) { this.Switch = Switch; }
        public Keyboard(decimal Price, bool Backlit, string Switch) : base(Price, Backlit) { this.Switch = Switch; }

        public override string ToString()
        {
            return base.ToString() + $"Switches: {Switch} | ";
        }
    }
}
