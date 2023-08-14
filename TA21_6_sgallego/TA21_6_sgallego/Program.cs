using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio6
{

    class Numero
    {

        static int Cifras(String numCifras)
        {
            return numCifras.Length;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduce el numero a comprobar: ");
            String numString = Console.ReadLine();

            if(int.TryParse(numString, out int num) && num > 0)
            {
                Console.WriteLine("El numero de cifras de {0} es {1}", num, Cifras(numString));
            }
            else
            {
                Console.WriteLine("Introduce un valor válido");
            }

        }
    }

}