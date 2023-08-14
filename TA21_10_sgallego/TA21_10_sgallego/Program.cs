using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio10
{

    class Numero
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, (num*i));
            }

        }
    }

}