namespace guia7
{
    class Bisiesto
    {
        public Bisiesto()
        {


            Console.WriteLine("Ingrese el año a evaluar: ");
            int año = Convert.ToInt32(Console.ReadLine());
            
               if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine($"El año {año} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto.");
            }
        }
    }
}