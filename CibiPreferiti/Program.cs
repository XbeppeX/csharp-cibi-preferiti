﻿using System;

namespace CibiPreferiti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "lasagne", "parmigiana", "pasta norma", "bistecca", "cotolette", "orata" };
            Console.WriteLine("Lunghezza array: " + cibiPreferiti.Length);

            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(cibiPreferiti[i] + " {0}° classificato",i+1);
            }

            Console.WriteLine(cibiPreferiti[0] + " è il tuo cibo Top preferito");

            Console.WriteLine(cibiPreferiti[cibiPreferiti.Length-1] + " è il tuo ultimo cibo preferito");

            if (cibiPreferiti.Length  %2 == 0)
            {
                Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2] + " e " + cibiPreferiti[cibiPreferiti.Length / 2 - 1] + " Sono i tuoi cibi mediani preferiti");
            }  else
            {
                Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2] + " è il tuo cibo mediano preferito");
            }

        }
    }
}
