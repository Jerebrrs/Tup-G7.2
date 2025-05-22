namespace Ejercicio3
{
    public class ListadoNotas
    {
        public ListadoNotas()
        {
            string nombre1, nombre2, nombre3;
            int libreta1, libreta2, libreta3;

            Console.WriteLine("Ingrese el nombre y libreta de 3 alumnos");
            Console.WriteLine("Ingrese el nombre y libreta del primer alumno");
            nombre1 = Console.ReadLine();
            libreta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre y libreta del segundo alumno.");
            nombre2 = Console.ReadLine();
            libreta2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre y libreta del tercer alumno.");
            nombre3 = Console.ReadLine();
            libreta3 = Convert.ToInt32(Console.ReadLine());



            if (libreta1 > libreta2)
            {
                if (libreta3 > libreta2)
                {
                    if (libreta3 > libreta1)
                    {
                        Console.WriteLine($"El orden es : {libreta3} , {libreta1} , {libreta2} .");
                    }
                    else
                    {
                        Console.WriteLine($"El orden es : {libreta1} , {libreta3} , {libreta2} .");

                    }
                }
                else
                {
                    Console.WriteLine($"El orden es : {libreta1} , {libreta2} , {libreta3} .");

                }
            }
            else
            {
                if (libreta3 > libreta1)
                {
                    if (libreta3 > libreta2)
                    {
                        Console.WriteLine($"El orden es : {libreta3} , {libreta2} , {libreta1} .");

                    }
                    else
                    {
                        Console.WriteLine($"El orden es : {libreta2} , {libreta3} , {libreta1} .");

                    }
                }
                else
                {
                 Console.WriteLine($"El orden es : {libreta2} , {libreta1} , {libreta3} .");
 
                }
            }

        }
    }
}