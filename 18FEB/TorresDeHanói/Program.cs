using System;

namespace TorresDeHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torres de Hanoi - Solución recursiva");
            Console.WriteLine("=================================");
            
            // Get the number of discs from the user
            Console.Write("Ingrese el número de discos: ");
            if (int.TryParse(Console.ReadLine(), out int numDisks) && numDisks > 0)
            {
                Console.WriteLine($"\nMovimientos para resolver Torres de Hanoi con {numDisks} discos:");
                
                // Start the recursive algorithm
                int totalMoves = SolveHanoi(numDisks, 'A', 'C', 'B');
                
                Console.WriteLine($"\nSe completó la solución en {totalMoves} movimientos.");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número positivo de discos.");
            }
            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Solves the Towers of Hanoi puzzle recursively
        /// </summary>
        /// <param name="n">Number of disks</param>
        /// <param name="source">Source tower</param>
        /// <param name="destination">Destination tower</param>
        /// <param name="auxiliary">Auxiliary tower</param>
        /// <returns>The total number of moves required</returns>
        static int SolveHanoi(int n, char source, char destination, char auxiliary)
        {
            int moveCount = 0;
            
            if (n == 1)
            {
                // Base case: move the smallest disk directly from source to destination
                Console.WriteLine($"Mover disco 1 desde torre {source} a torre {destination}");
                return 1;
            }
            
            // Step 1: Move n-1 disks from source to auxiliary using destination as auxiliary
            moveCount += SolveHanoi(n - 1, source, auxiliary, destination);
            
            // Step 2: Move the largest disk from source to destination
            Console.WriteLine($"Mover disco {n} desde torre {source} a torre {destination}");
            moveCount++;
            
            // Step 3: Move n-1 disks from auxiliary to destination using source as auxiliary
            moveCount += SolveHanoi(n - 1, auxiliary, destination, source);
            
            return moveCount;
        }
        
        /// <summary>
        /// Alternative method to calculate the number of moves without recursion
        /// </summary>
        /// <param name="numDisks">Number of disks</param>
        /// <returns>The total number of moves required</returns>
        static int CalculateMinimumMoves(int numDisks)
        {
            // Formula: 2^n - 1
            return (int)Math.Pow(2, numDisks) - 1;
        }
        
        /// <summary>
        /// Visual representation of Towers of Hanoi (can be implemented for more interactive experience)
        /// </summary>
        static void DisplayTowers(int numDisks, int[] towerA, int[] towerB, int[] towerC)
        {
            Console.WriteLine("\nEstado actual de las torres:");
            Console.WriteLine("Torre A: " + string.Join(", ", towerA));
            Console.WriteLine("Torre B: " + string.Join(", ", towerB));
            Console.WriteLine("Torre C: " + string.Join(", ", towerC));
        }
    }
}