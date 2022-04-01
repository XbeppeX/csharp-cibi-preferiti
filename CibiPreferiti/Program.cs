using System;

namespace CibiPreferiti
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Inizializzo array
            string[] cibiPreferiti = { "lasagne", "parmigiana", "pasta norma", "bistecca", "cotolette", "orata" };
            Console.WriteLine("Lunghezza array: " + cibiPreferiti.Length);
            
            //Ciclo for per printare a schermo classifica
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(cibiPreferiti[i] + " {0}° classificato",i+1);
            }

            //Primo e ultimo cibo preferito
            Console.WriteLine(cibiPreferiti[0] + " è il tuo cibo Top preferito");

            Console.WriteLine(cibiPreferiti[cibiPreferiti.Length-1] + " è il tuo ultimo cibo preferito");

            //BONUS: cibi preferiti mediani se pari ne stampo 2, se dispari 1
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
