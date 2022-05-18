using LAB_2.Products;
using System;


namespace LAB_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container contain = new Container();
            Console.WriteLine(contain.count);

            contain.Add(new Monitor("HP", 4550, 60, 20));
            contain.Add(new Monitor("Apple", 105000, 60, 32));
            contain.Add(new Mouse("DELL", 1260, true, 5800));
            contain.Add(new Mouse("Logitech", 2800, true, 6120));
            contain.Add(new Keyboard("Philips", 3850, false, "SPK8401B/01"));
            contain.Add(new Keyboard("Razer", 5250, true, "Hamster red"));
            contain.Add(new Keyboard("Logitech", 1650, false, "TruDug"));

            //////////////////////////////////////////////

            Console.WriteLine("Индексатор по номеру");
            Console.WriteLine(contain[4].ToString());

            //////////////////////////////////////////////
            
            Console.WriteLine("Индексатор по названию");
            Console.WriteLine(contain["Logitech"].ToString());
            //Console.WriteLine(contain["Samsung"].ToString());              //Для провреки если наименование с таким именем нет

            //////////////////////////////////////////////

            Console.WriteLine("Индексатор по цене");
            Console.WriteLine(contain[decimal.Parse("105000")].ToString());
            //Console.WriteLine(contain[decimal.Parse("1")].ToString());     //Для проверки если в списке такого нет

            Console.ReadKey();
        }
    }
}