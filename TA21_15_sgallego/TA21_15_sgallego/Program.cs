using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio15
{

    class Numero
    {

        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[5];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array2[array.Length - 1 - i] = array[i];
                Console.WriteLine(array2[array.Length - 1 - i]);
            }

        }
    }

}