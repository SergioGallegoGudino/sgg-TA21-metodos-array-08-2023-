using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio14
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

            Console.WriteLine("Introduce un numero para comprobar si se encuentra en la array: ");
            int num = int.Parse(Console.ReadLine());

            bool existe = Array.Exists(array, numero => numero == num);

            if (existe)
            {
                Console.WriteLine("El numero existe en la array");
            }
            else
            {
                Console.WriteLine("El numero no existe en la array");
            }
        }
    }

}