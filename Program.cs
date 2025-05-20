using System;
using Ejercisio1;

namespace MiNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la opcion del ejercicio de a G7.2 que quiera ejecutar.\n" +
            "Opcion 1: Condicion de alumno.\n" +
            "Opcion 0:Para terminar la ejecucion.\n"+
            ("<=========================================>"));

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                var alumnos = new Alumnos();
                break;
                case 0:
                Console.WriteLine("Terminando ejecución.");
                break;
                default:
                Console.WriteLine("Opción no válida.");
                break;
            }
        }
    }
}