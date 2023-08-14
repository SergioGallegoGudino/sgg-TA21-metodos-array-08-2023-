using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio4
{

    class Numero
    {

        static int Factorial(int num)
        {
            if (num == 0 || num == 1) return 1;

            int factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduce el numero a comprobar: ");
            String numString = Console.ReadLine();
            int num = int.Parse(numString);

            Console.WriteLine("El factorial de {0} es {1}", num, Factorial(num));

        }
    }

}
