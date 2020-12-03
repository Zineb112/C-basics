using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mois = new List<string>();
            mois.Add("janvier");
            mois.Add("févier");
            mois.Add("mars");
            mois.Add("avril");
            mois.Add("mai");
            mois.Add("juin");
            mois.Add("juillet");
            mois.Add("août");
            mois.Add("septembre");
            mois.Add("octobre");
            mois.Add("novembre");

            //Insérer un élément dans la liste à la première position.
            mois.Insert(0, "jour");

            //Supprimer le troisième élément de cette liste.
            mois.RemoveAt(2);


            foreach (string ms in mois)
            {
                Console.WriteLine(ms);

            }
            Console.WriteLine("\nla troisième ligne de cette liste : " + mois[2]);

            Console.WriteLine("\nla valeur de l'index : " + mois[5]);

            if (mois.Contains("juin"))
            {
                Console.WriteLine("\n juin trouvé!");
            }


            // Trier les éléments de la liste
            mois.Sort();

            // Declare an array with 15 elements.
            string[] array = new string[15];

            //copier le tableau dans la liste
            List<string> Mylist = new List<string>(mois);

            //copier le tableau dans la liste
            List<string> mylist = new List<string>(mois);

            // Parcourir la liste 
            foreach (string item in mylist)
            {
                Console.WriteLine(item);

            }


        }

    }
}
