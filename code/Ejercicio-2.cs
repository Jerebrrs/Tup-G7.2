namespace Ejercicio2
{
    public class NumeroTipo
    {
        public NumeroTipo()
        {
            Console.WriteLine("Por favor ingrese un numero a evaluar:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine($"El numero ingresado es {numero} por lo tanto es Nulo.");
            }
            else if (numero > 0)
            {
                Console.WriteLine($"El numero ingresado es {numero} por lo tanto es Positivo.");
            }
            else
            {
                Console.WriteLine($"El numero ingresado es {numero} por lo tanto es Negativo.");
            }
            
        }
    }
}