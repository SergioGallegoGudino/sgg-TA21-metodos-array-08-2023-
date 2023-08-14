using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio3
{

    class Numero
    {

        static Boolean esPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            if (num <= 3)
            {
                return true;
            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduce el numero a comprobar: ");
            String numString = Console.ReadLine();
            int num = int.Parse(numString);

            if (esPrimo(num))
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo.");
            }

        }
    }

}
