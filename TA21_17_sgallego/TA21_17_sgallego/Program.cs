using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio17
{

    class Numero
    {
        static int rellenar(int i)
        {
            Console.WriteLine("Introduce el numero de la posicion {0}", i);
            return int.Parse(Console.ReadLine());
        }
        static void mostrar(int index, int valor)
        {
            Console.WriteLine("El valor {0} se encuentra en el índice {1}", valor, index);
        }

        public static void Main(string[] args)
        {

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rellenar(i);
                mostrar(Array.IndexOf(array, array[i]), array[i]);
            }
        }
    }

}

