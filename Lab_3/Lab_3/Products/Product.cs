using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1.Products
{
    public class Product
    {
        private string _name;
        private decimal _price;

        public Product() { name = $"{nameof(Product)}"; price = 0; }
        public Product(string Name, decimal Price) { name = Name; price = Price; }
        public Product(decimal Price) { name = $"{nameof(Product)}"; price = Price; }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }
        public override string ToString() { return $"Наименование: {name} | Прайс: {price} UAH | "; }
    }
}


