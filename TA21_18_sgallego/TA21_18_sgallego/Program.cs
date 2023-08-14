using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio18
{

    class Numero
    {

        static int numRandom()
        {
            Random random = new Random();
            int valorRandom = random.Next(0, 9);
            return valorRandom;
        }

        static void mostrarContenido(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++) {

                Console.WriteLine("El numero de la posicion {0} es {1}", i, array[i]);
                suma += array[i];
            }
            Console.WriteLine("La suma es {0}", suma);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud de la array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numRandom();
            }
            mostrarContenido(array);
        }
    }

}

