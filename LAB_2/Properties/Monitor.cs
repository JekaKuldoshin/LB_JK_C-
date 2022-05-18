using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.Products
{
    public class Monitor : Product
    {
        private short _size;
        private short _refreshRate;
        
        public Monitor()
        {
            rate = 60;
            size = 0;
        }
        public Monitor(decimal Price, short Rate, short Size) : base(Price)
        {
            rate = Rate;
            size = Size;
        }
        public Monitor(string Name, decimal Price, short Rate, short Size) : base(Name, Price)
        {
            size = Size;
            rate = Rate;
        }

        public short size
        {
            get { return _size; }
            set { _size = value; }
        }

        public short rate
        {
            get { return _refreshRate; }
            set { _refreshRate = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"Частота обновлений: {rate} Hz | Размер: {size} дюймов | ";
        }

    }
}
