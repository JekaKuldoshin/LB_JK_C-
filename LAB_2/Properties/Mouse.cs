using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.Products
{
    public class Mouse : Periphery
    {

        private int _dpi;

        public Mouse(string Name, decimal Price, bool Backlit, int Dpi) : base(Name, Price, Backlit)
        {
            dpi = Dpi;
        }
        public Mouse(decimal Price, bool Backlit, int Dpi) : base(Price, Backlit)
        {
            dpi = Dpi;
        }

        public int dpi
        {
            get { return _dpi; }
            set { _dpi = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"ДПИ: {dpi} | ";
        }


    }
}
