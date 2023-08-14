using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio11
{

    class Numero
    {

        public static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
            Console.WriteLine(suma);
        }
    }

}