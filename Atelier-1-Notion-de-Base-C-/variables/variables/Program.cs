using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produit;
            int prix;


            Console.WriteLine("Enter le nom de produit:");
            produit = Console.ReadLine();

            Console.WriteLine("Enter le prix de produit:");
            prix = Convert.ToInt32(Console.ReadLine());


            int TVA = prix * 19 / 100;
            double result = prix + TVA;

            Console.WriteLine("Le prix de votre produit" + " " + "<" + produit + ">" + " " + "est de" + " " + result + "DH.");
        }
    }
}