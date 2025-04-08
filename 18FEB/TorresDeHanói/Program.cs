using System;

namespace TorresDeHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torres de Hanoi - Solución recursiva");
            Console.WriteLine("=================================");
            
            // Obtener el número de discos del usuario
            Console.Write("Ingrese el número de discos: ");
            if (int.TryParse(Console.ReadLine(), out int numDiscos) && numDiscos > 0)
            {
                Console.WriteLine($"\nMovimientos para resolver Torres de Hanoi con {numDiscos} discos:");
                
                // Iniciar el algoritmo recursivo
                int movimientosTotales = ResolverHanoi(numDiscos, 'A', 'C', 'B');
                
                Console.WriteLine($"\nSe completó la solución en {movimientosTotales} movimientos.");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número positivo de discos.");
            }
            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Resuelve el puzzle de Torres de Hanoi recursivamente
        /// </summary>
        /// <param name="n">Número de discos</param>
        /// <param name="origen">Torre de origen</param>
        /// <param name="destino">Torre de destino</param>
        /// <param name="auxiliar">Torre auxiliar</param>
        /// <returns>El número total de movimientos requeridos</returns>
        static int ResolverHanoi(int n, char origen, char destino, char auxiliar)
        {
            int contadorMovimientos = 0;
            
            if (n == 1)
            {
                // Caso base: mover el disco más pequeño directamente desde origen hasta destino
                Console.WriteLine($"Mover disco 1 desde torre {origen} a torre {destino}");
                return 1;
            }
            
            // Paso 1: Mover n-1 discos desde origen hasta auxiliar usando destino como auxiliar
            contadorMovimientos += ResolverHanoi(n - 1, origen, auxiliar, destino);
            
            // Paso 2: Mover el disco más grande desde origen hasta destino
            Console.WriteLine($"Mover disco {n} desde torre {origen} a torre {destino}");
            contadorMovimientos++;
            
            // Paso 3: Mover n-1 discos desde auxiliar hasta destino usando origen como auxiliar
            contadorMovimientos += ResolverHanoi(n - 1, auxiliar, destino, origen);
            
            return contadorMovimientos;
        }
        
        /// <summary>
        /// Método alternativo para calcular el número de movimientos sin recursión
        /// </summary>
        /// <param name="numDiscos">Número de discos</param>
        /// <returns>El número total de movimientos requeridos</returns>
        static int CalcularMovimientosMinimos(int numDiscos)
        {
            // Fórmula: 2^n - 1
            return (int)Math.Pow(2, numDiscos) - 1;
        }
        
        /// <summary>
        /// Representación visual de Torres de Hanoi (puede implementarse para una experiencia más interactiva)
        /// </summary>
        static void MostrarTorres(int numDiscos, int[] torreA, int[] torreB, int[] torreC)
        {
            Console.WriteLine("\nEstado actual de las torres:");
            Console.WriteLine("Torre A: " + string.Join(", ", torreA));
            Console.WriteLine("Torre B: " + string.Join(", ", torreB));
            Console.WriteLine("Torre C: " + string.Join(", ", torreC));
        }
    }
}