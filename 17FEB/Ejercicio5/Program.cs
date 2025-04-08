using System;

class AguinaldoCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Calculadora de Aguinaldo =====");
        Console.WriteLine("Este programa calcula el monto del aguinaldo para un trabajador.");
        Console.WriteLine("El aguinaldo corresponde a 15 días de salario.");
        
        try
        {
            // Obtener el salario diario del trabajador
            Console.Write("\nIngrese el salario diario del trabajador: $");
            double dailySalary = double.Parse(Console.ReadLine());
            
            if (dailySalary <= 0)
            {
                Console.WriteLine("El salario diario debe ser mayor que cero.");
                return;
            }
            
            // Calcular el aguinaldo (15 días de salario)
            const int AGUINALDO_DAYS = 15;
            double aguinaldoAmount = dailySalary * AGUINALDO_DAYS;
            
            // Mostrar resultados
            Console.WriteLine("\n===== Resultado del Cálculo =====");
            Console.WriteLine($"Salario diario: ${dailySalary:F2}");
            Console.WriteLine($"Días de aguinaldo: {AGUINALDO_DAYS}");
            Console.WriteLine($"Monto total del aguinaldo: ${aguinaldoAmount:F2}");
            
            // Información adicional
            double monthlySalary = dailySalary * 30; // Estimado de salario mensual
            double aguinaldoPercentage = (aguinaldoAmount / monthlySalary) * 100;
            
            Console.WriteLine("\n===== Información Adicional =====");
            Console.WriteLine($"Este aguinaldo representa aproximadamente el {aguinaldoPercentage:F2}% de un salario mensual.");
            
            // Opciones para días trabajados en el año (proporcional)
            Console.WriteLine("\n===== Cálculo Proporcional =====");
            Console.WriteLine("Si el trabajador no laboró el año completo, puede calcular el aguinaldo proporcional.");
            Console.Write("¿Desea calcular el aguinaldo proporcional? (S/N): ");
            string response = Console.ReadLine().Trim().ToUpper();
            
            if (response == "S")
            {
                Console.Write("Ingrese el número de días trabajados en el año: ");
                int daysWorked = int.Parse(Console.ReadLine());
                
                if (daysWorked <= 0 || daysWorked > 365)
                {
                    Console.WriteLine("El número de días trabajados debe estar entre 1 y 365.");
                    return;
                }
                
                // Calcular aguinaldo proporcional
                double proportionalFactor = (double)daysWorked / 365;
                double proportionalAguinaldo = aguinaldoAmount * proportionalFactor;
                
                Console.WriteLine("\n===== Aguinaldo Proporcional =====");
                Console.WriteLine($"Días trabajados en el año: {daysWorked}");
                Console.WriteLine($"Proporción del año trabajado: {proportionalFactor:P2}");
                Console.WriteLine($"Aguinaldo proporcional: ${proportionalAguinaldo:F2}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Por favor ingrese valores numéricos válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError inesperado: {ex.Message}");
        }
        
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}