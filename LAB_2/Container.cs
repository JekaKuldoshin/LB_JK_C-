using LAB_2.Products;
using System;
using System.Text;

namespace LAB_2
{
    internal class Container
    {
        Product[] data;
        public void Add(Product p)
        {
            Product[] newdata = new Product[count + 1];

            for (int i = 0; i < count; i++)
                newdata[i] = data[i];

            newdata[count] = p;
            data = newdata;

        }
        public int count
        {
            get
            {
                return data != null ? data.Length : 0;
            }
        }

        public Product this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public Product this[string name]
        {
            get
            {
                foreach (var pr in data)
                {
                    if (pr.name == name) return pr;
                }
                throw new Exception("Неизвестное имя");

            }
        }

        public Product this[decimal price]
        {
            get
            {
                foreach (var pr in data)
                {
                    if (pr.price == price) return pr;
                }
                throw new Exception("Неизвестный прайс");
            }
        }

        public void Remove(int index)
        {
            Product[] newdata = new Product[count - 1];

            for (int i = 0; i < index; i++)
                newdata[i] = data[i];
            for (int j = index + 1; j < count; j++)
                newdata[j - 1] = data[j];

            data = newdata;
        }

        public void sortPrice()
        {
            decimal temp;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (data[i].price < data[j].price)
                    {
                        temp = data[i].price;
                        data[i].price = data[j].price;
                        data[j].price = temp;
                    }

                }



            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
                sb.Append(data[i].ToString() + '\n');
            return sb.ToString();
        }

    }
}