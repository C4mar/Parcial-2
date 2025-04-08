using System;

namespace Factorial
{
    class Program
    {
        static int factorial (int n)
        {
            if (n==0){
                return 1;
            }
            else{
                return n*factorial(n-1);
            }
        }

        static void Main()
        {
            Console.WriteLine("Introduzca un número entero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El factorial de {n} es {factorial(n)}");
        }
    }
}