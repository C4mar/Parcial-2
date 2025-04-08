using System;

class WaterConsumption
{
    static void Main(string[] args)
    {
        Console.WriteLine("====== Calculadora de Consumo de Agua ======");
        Console.WriteLine("Este programa calcula los litros de agua consumidos por una familia en un mes.");
        
        // Solicitar la entrada del usuario (metros cúbicos)
        Console.Write("\nIngrese el consumo de agua en metros cúbicos: ");
        string input = Console.ReadLine();
        
        // Validar y convertir la entrada
        if (double.TryParse(input, out double cubicMeters))
        {
            // Realizar el cálculo (1 metro cúbico = 1000 litros)
            double liters = cubicMeters * 1000;
            
            // Mostrar el resultado
            Console.WriteLine($"\nConsumo en metros cúbicos: {cubicMeters:F2} m³");
            Console.WriteLine($"Consumo en litros: {liters:F2} L");
            
            // Información adicional sobre el consumo
            Console.WriteLine("\n=== Información sobre su consumo ===");
            double averageDailyLiters = liters / 30;
            Console.WriteLine($"Consumo promedio diario: {averageDailyLiters:F2} litros");
            
            // Evaluación del consumo según estándares comunes
            if (cubicMeters < 10)
                Console.WriteLine("Su consumo es bajo.");
            else if (cubicMeters < 20)
                Console.WriteLine("Su consumo es moderado.");
            else
                Console.WriteLine("Su consumo es alto. Considere implementar medidas de ahorro de agua.");
        }
        else
        {
            Console.WriteLine("\nError: Por favor ingrese un valor numérico válido.");
        }
        
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}