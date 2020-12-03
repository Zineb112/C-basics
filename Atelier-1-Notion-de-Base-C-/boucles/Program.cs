using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 50;
            while (a < 30)
            {
                Console.WriteLine(a * b);
                a++;
            }
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;

            }
            int x = 1;
            while (x <= 15)
            {
                Console.WriteLine("On y arrive presque...");
                x++;

            }
            int y = 20;
            while (y >= 1)
            {
                Console.WriteLine("C'est presque bon...");
                y--;
            }
            int z = 1;
            while (z <= 100)
            {
                Console.WriteLine("On tient le bon bout...");
                i += 15;
            }
            int v = 200;
            while (v >= 0)
            {
                Console.WriteLine("Enfin ! ! !");
                v -= 12;
            }
        }
    }
}