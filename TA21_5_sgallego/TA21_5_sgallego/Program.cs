using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio5
{

    class Numero
    {

        static String Binario(int num)
        {
            if (num == 0) return "0";

            String binario = "";

            while (num > 0)
            {
                int residuo = num % 2;
                binario = residuo.ToString() + binario;
                num /= 2;
            }
            return binario;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduce el numero a comprobar: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("El numero binario de {0} es {1}", num, Binario(num));

        }
    }

}