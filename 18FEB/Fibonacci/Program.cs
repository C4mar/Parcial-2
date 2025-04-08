using System;

namespace SerieDelFibonacci
{
    class Program
    {    
        static void Main()
        {
            Console.WriteLine("La posicion de la torre de fibonacci que desea conocer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El número en la posición {n} de la serie de Fibonacci es {fibonacci(n)}");
        }

        static int fibonacci(int n)
        {
            if (n == 0) {
                return 0;
            } else if (n == 1) {
                return 1;
            } else { 
                return fibonacci(n-1) + fibonacci(n-2);
            }
        }

    }   
}
