using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB_2.Products
{
    public class Periphery:Product
    {
        private bool _backlit;

        public bool backlit
        {
            get { return _backlit; }
            set { _backlit = value; }
        }

        public Periphery() { backlit = false; }
        public Periphery(string Name, decimal Price, bool Backlit) : base(Name, Price) { backlit = Backlit; }
        public Periphery(decimal Price, bool Backlit) : base(Price) { backlit = Backlit; }

        public override string ToString()
        {
            return base.ToString() + $"Подсветка: {backlit} | ";
        }


    }
}