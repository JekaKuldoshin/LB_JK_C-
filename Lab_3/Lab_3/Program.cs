using System;
using LAB_1.Products;


namespace LAB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Console.WriteLine(product.ToString());
            Monitor monitor = new Monitor("HP",4550, 60, 20);
            Console.WriteLine(monitor.ToString());
            Mouse mouse = new Mouse("DELL", 1260, true, 5800);
            Console.WriteLine(mouse.ToString());
            Keyboard keyboard = new Keyboard("Philips", 3850, false, "SPK8401B/01");
            Console.WriteLine(keyboard.ToString());
            Console.ReadKey();
        }
    }
}
