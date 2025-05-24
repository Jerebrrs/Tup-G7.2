namespace guia7
{
    public class NumeroMenor
    {
        public NumeroMenor()
        {

            int menor=99999, numero, orden=1;

            Console.WriteLine("Por favor ingrese 5 numeros diferentes.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el {i + 1} numero.");
                numero = Convert.ToInt32(Console.ReadLine());

          
                if (numero < menor)
                {
                    menor = numero;
                    orden = i +1;
                }

            }

            Console.WriteLine($"De los 5 numeros ingresados el menor fue {menor} en la posicion {orden}.");
        }
    }
}