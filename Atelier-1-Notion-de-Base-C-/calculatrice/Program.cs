using System;


namespace calculatrice
{
    class Program
    {

        static void Main(string[] args)
        {

            double firstnumber;
            double secondnumber;
            double result;
            string ops;

            Console.WriteLine("Calculator");


            Console.WriteLine("Enter the first number");
            firstnumber = double.Parse(Console.ReadLine());


            Console.WriteLine("Slect an Operator (+, -,*, or /)");
            ops = Console.ReadLine();


            Console.WriteLine("Enter the second number");
            secondnumber = double.Parse(Console.ReadLine());

            if (ops == "+")
            {
                result = firstnumber + secondnumber;
                Console.Write(result);
            }
            if (ops == "-")
            {
                result = firstnumber - secondnumber;
                Console.Write(result);
            }
            if (ops == "*")
            {
                result = firstnumber * secondnumber;
                Console.Write(result);
            }
            if (ops == "/")
            {
                result = firstnumber / secondnumber;
                Console.Write(result);
            }

            if (ops == "%")
            {
                result = firstnumber %
                    secondnumber;
                Console.Write(result);
            }


            Console.WriteLine("\n\nPress Entrance to exit...");
            Console.ReadKey();

        }
    }
}