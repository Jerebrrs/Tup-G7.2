namespace Ejercisio1
{
    public class Alumnos
    {
        public Alumnos()
        {
            Console.WriteLine("Por favor Ingrese la condición para Promocionar la materia(Numero del 6 al 9): ");
            int condicion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese las 3 notas del alumno: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            int nota2 = Convert.ToInt32(Console.ReadLine());
            int nota3 = Convert.ToInt32(Console.ReadLine());



            double promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio < condicion)
            {
                Console.WriteLine($"El alumno desaprobo su nota final es {promedio}");
            }
            else
            {
                Console.WriteLine($"El alumno promociono su nota final es {promedio}.");
            }
        }
    }
}