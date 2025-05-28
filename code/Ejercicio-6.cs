namespace guia7
{
    public class Tenis
    {
        

        public Tenis()
        {
            string jug1, jug2;
            int setsGanadosJug1 = 0,setsGanadosJug2 = 0;
            
            Console.WriteLine("Escriba el nombre de los dos jugadores:");
            jug1 = Console.ReadLine()!;
            jug2 = Console.ReadLine()!;

            Console.WriteLine("Ingrese los puntos del Set 1:");
            Console.Write(jug1 + ": ");
            int set1Jug1 = Convert.ToInt32(Console.ReadLine()!);
            Console.Write(jug2 + ": ");
            int set1Jug2 = Convert.ToInt32(Console.ReadLine()!);

            if (set1Jug1 > set1Jug2)
            {
                setsGanadosJug1++;
            }
            else
            {
                setsGanadosJug2++;
            }

            Console.WriteLine("Ingrese los puntos del Set 2:");
            Console.Write(jug1 + ": ");
            int set2Jug1 =  Convert.ToInt32(Console.ReadLine()!);
            Console.Write(jug2 + ": ");
            int set2Jug2 =  Convert.ToInt32(Console.ReadLine()!);

            if (set2Jug1 > set2Jug2)
            {
                setsGanadosJug1++;
            }
            else
            {
                setsGanadosJug2++;
            }

            Console.WriteLine("Ingrese los puntos del Set 3:");
            Console.Write(jug1 + ": ");
            int set3Jug1 =  Convert.ToInt32(Console.ReadLine()!);
            Console.Write(jug2 + ": ");
            int set3Jug2 =  Convert.ToInt32(Console.ReadLine()!);

            if (set3Jug1 > set3Jug2)
            {
                setsGanadosJug1++;
            }
            else
            {
                setsGanadosJug2++;
            }

            if (setsGanadosJug1 > setsGanadosJug2)
            {
                Console.WriteLine("Ganador: " + jug1);
            }
            else
            {
                Console.WriteLine("Ganador: " + jug2);
            }
        
        }
    }
}


