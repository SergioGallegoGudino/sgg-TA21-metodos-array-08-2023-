using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio7
{

    class Numero
    {

        static void Cambio(double precio, String moneda)
        {
            switch (moneda)
            {
                case "Libras":
                    Console.WriteLine("El cambio a libras es de {0}", (precio * 0.86));
                    break;
                case "Dolares":
                    Console.WriteLine("El cambio a dolares es de {0}", (precio * 1.28611));
                    break;
                case "Yenes":
                    Console.WriteLine("El cambio a yenes es de {0}", (precio * 129.852));
                    break;
                default:
                    Console.WriteLine("Introduce un cambio válido");
                    break;
            }
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduce el precio a cambiar: ");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la moneda de cambio (Libras/Dolares/Yenes):");
            String cambio = Console.ReadLine();

            Cambio(precio, cambio);
        }
    }

}