using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1
{

    class Forma
    {

        public double Circulo()
        {
            Console.WriteLine("Introduce el radio del circulo: ");
            String radioString = Console.ReadLine();

            double radio = double.Parse(radioString);

            double area = (radio*radio)*3.14;
            return area;
        }

        public double Triangulo()
        {

            Console.WriteLine("Introduce la base del triangulo: ");
            String baseString = Console.ReadLine();
            double baseT = double.Parse(baseString);

            Console.WriteLine("Introduce la altura del triangulo: ");
            String alturaString = Console.ReadLine();

            double altura = double.Parse(alturaString);

            double area = (baseT*altura)/2;
            return area;
        }

        public double Cuadrado()
        {
            Console.WriteLine("Introduce el lado del cuadrado: ");
            String ladoString = Console.ReadLine();

            double lado = double.Parse(ladoString);
            double area = lado * lado;
            return area;
        }

        public static void Main(string[] args)
        {

            double resultado = 0;

            Console.WriteLine("Introduce la forma a calcular el area (Triangulo, Cuadrado, Circulo): ");
            String forma = Console.ReadLine();

            Forma f = new Forma();

            switch (forma)
            {
                case "Triangulo":
                    resultado = f.Triangulo();
                    break;

                case "Cuadrado":
                    resultado = f.Cuadrado();
                    break;

                case "Circulo":
                    resultado = f.Circulo();
                    break;
            }

            Console.WriteLine("El resultado es " + resultado);

        }
    }

}
