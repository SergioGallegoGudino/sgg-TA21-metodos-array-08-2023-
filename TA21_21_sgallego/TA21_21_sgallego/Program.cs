using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio21
{

    class Numero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud de la array: ");

            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            int[] array2 = new int[num];
            Console.WriteLine("Introduce el numero del ultimo digito a comprobar: ");
            int digito = int.Parse(Console.ReadLine());
            int numRandom = 0;
            if (digito >= 0 && digito <= 9)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Random random = new Random();
                    numRandom = random.Next(1, 300);
                    array[i] = numRandom;

                    if (array[i] % 10 == digito)
                    {
                        array2[i] = numRandom;
                        Console.WriteLine(array2[i]);
                    }

                }
            }
            else
            {
                Console.WriteLine("Digito no valido, intentalo de nuevo");
            }

        }
    }

}