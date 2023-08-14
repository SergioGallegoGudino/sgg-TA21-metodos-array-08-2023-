using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio19
{

    class Numero
    {

        static int numRandomPrimo()
        {
            Boolean primo = false;
            int valorRandom = 0;
            while (!primo)
            {
                Random random = new Random();
                valorRandom = random.Next(0, 9);
                primo = true;
                if (valorRandom <= 1)
                {
                    primo = false;
                }

                if (valorRandom <= 3)
                {
                    primo = true;
                }

                if (valorRandom % 2 == 0 || valorRandom % 3 == 0)
                {
                    primo = false;
                }

                for (int i = 5; i * i <= valorRandom; i += 6)
                {
                    if (valorRandom % i == 0 || valorRandom % (i + 2) == 0)
                    {
                        primo = false;
                    }
                }

            }
            return valorRandom;

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud de la array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numRandomPrimo();
                if (array[i] > max)
                {
                    max = array[i];
                }
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("El numero mas grande es {0}", max);
        }
    }

}
