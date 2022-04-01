using System;

namespace CibiPreferiti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "lasagne", "parmigiana", "pasta norma", "bistecca", "cotolette" };
            Console.WriteLine("Lunghezza array: " + cibiPreferiti.Length);

            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(cibiPreferiti[i] + " {0}° classificato",i+1);
            }

            Console.WriteLine(cibiPreferiti[0] + "è il tuo cibo Top preferito");

            Console.WriteLine(cibiPreferiti[cibiPreferiti.Length-1] + "è il tuo ultimo cibo preferito");



        }
    }
}
