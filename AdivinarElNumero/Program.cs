using System;

namespace AdivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var num = r.Next(101);
            int res;
            int intentos = 0;
            do
            {
                Console.WriteLine("Elija el numero: ");
                res = Convert.ToInt32(Console.ReadLine());
                if (res > num)
                    Console.WriteLine($"El numero {res} es mayor que el numero aleatorio\n");
                if (res < num)
                    Console.WriteLine($"El numero {res} es menor que el numero aleatorio\n");

                intentos++;
            } while (num != res);

            Console.WriteLine($"Encontraste el numero {num} en {intentos} intentos");
        }
    }
}
