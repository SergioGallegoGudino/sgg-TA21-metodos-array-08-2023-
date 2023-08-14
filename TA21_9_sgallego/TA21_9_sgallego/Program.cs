using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio9
{

    class Numero
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud de la array: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] array = new int[longitud];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduce el valor de la posicion {0}", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }

}