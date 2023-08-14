using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio2
{

    class Numero
    {

        static int generarAleatorios(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Indica la cantidad de numeros aleatorios a generar: ");
            String cantidadString = Console.ReadLine();
            int cantidad = int.Parse(cantidadString);

            Console.WriteLine("Indica el numero minimo: ");
            String minString = Console.ReadLine();
            int min = int.Parse(minString);

            Console.WriteLine("Indica el numero maximo: ");
            String maxString = Console.ReadLine();
            int max = int.Parse(maxString);

            int num = 0;

            for (int i = 0; i < cantidad; i++)
            {
                num = generarAleatorios(min, max);
                Console.WriteLine(num);
            }

        }
    }

}
