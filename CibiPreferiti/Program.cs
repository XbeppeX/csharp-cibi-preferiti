using System;

namespace CibiPreferiti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "lasagne", "parmigiana", "pasta norma", "bistecca", "cotolette" };
            Console.WriteLine(cibiPreferiti.Length);

            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(cibiPreferiti[i] + " {0}° classificato",i+1);
            }

        }
    }
}
