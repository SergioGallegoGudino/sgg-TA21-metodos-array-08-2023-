using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio13
{

    class Numero
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud de la array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.WriteLine(array[i]);
            }

        }
    }

}