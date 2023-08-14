using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio16
{

    class Numero
    {

        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 2, 1 };
            Boolean capicuo = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[array.Length-1-i])
                {
                    capicuo = false;
                }
            }

            if (capicuo)
            {
                Console.WriteLine("La array es capicua");
            }
            else
            {
                Console.WriteLine("La array no es capicua");
            }

        }
    }

}
