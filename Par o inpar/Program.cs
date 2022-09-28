using System;

namespace Par_o_inpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numero;

            Console.WriteLine("Dame el numero y te dire si es par o impar");
            numero = Convert.ToDouble (Console.ReadLine());

            if (numero %2 ==0)
            {
                Console.WriteLine("El numero es par");

            }
            else
            {
                Console.WriteLine("El numero es impar");

            }
        }
    }
}
