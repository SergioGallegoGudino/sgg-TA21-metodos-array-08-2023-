using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio20
{

    class Numero
    {
        static void multiplicar(int[] array, int[] array2, int[] array4)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array4[i] = array[i] * array2[i];
            }
        }

        static void mostrarArray(int[] array)
        {
            for(int i = 0;i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud de la array: ");
            int num = int.Parse(Console.ReadLine());
            int[] array  = new int[num];
            int[] array2 = new int[num];
            int[] array3 = new int[num];
            int[] array4 = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                array[i] = random.Next(0,9);
                array3[i] = random.Next(0, 9);
                array2[i] = array[i];
            }
            multiplicar(array, array2, array4);
            Console.WriteLine("Array 1");
            mostrarArray(array);
            Console.WriteLine("Array 2");
            mostrarArray(array2);
            Console.WriteLine("Array 3");
            mostrarArray(array3);
            Console.WriteLine("Array 4");
            mostrarArray(array4);
        }
    }

}