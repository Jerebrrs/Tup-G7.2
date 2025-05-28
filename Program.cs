using System;

namespace guia7
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opcion del ejercicio de a G7.2 que quiera ejecutar.\n" +
                                  "Opcion 1: Condicion de alumno.\n" +
                                  "Opcion 2: Tipo numero (Nulo, Positivo, Negativo).\n" +
                                  "Opcion 3: Listado ordenado de alumnos.\n" +
                                  "Opcion 4: Numero menor.\n" +
                                  "Opcion 5: Tenis.\n" +
                                    "Opcion 6: Biciesto.\n" +
                                  "Opcion 0: Para terminar la ejecucion.\n" +
                                  "<=========================================>");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Alumnos alumnos = new Alumnos();
                        break;
                    case 2:
                        NumeroTipo tipoNumero = new NumeroTipo();
                        break;
                    case 3:
                        ListadoNotas listadoAlumno = new ListadoNotas();
                        break;
                    case 4:
                        NumeroMenor numeroMenor = new NumeroMenor();
                        break;
                    case 5:
                        Tenis tenis = new Tenis();
                        break;
                    case 6:
                         new Bisiesto();
                        break;
                    case 0:
                        Console.WriteLine("Terminando ejecución.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("Presione una tecla cualquiera para continuar.");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
