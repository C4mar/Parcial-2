using System;

class DogFoodCalculator
{
    static void Main(string[] args)
    {
        // Constants
        const double DAILY_CONSUMPTION_GRAMS = 750.0; // grams per day per dog
        const double GRAMS_PER_KG = 1000.0;
        
        Console.WriteLine("===== Calculadora de Alimento para Perros =====");
        Console.WriteLine("Este programa calcula cuántos kilogramos de alimento");
        Console.WriteLine("debe dejar para su(s) perro(s) cuando salga de viaje.");
        Console.WriteLine("Consumo estimado: 750 gramos por perro por día");
        
        try
        {
            // Get number of dogs
            Console.Write("\nIngrese el número de perros: ");
            int numberOfDogs = int.Parse(Console.ReadLine());
            
            if (numberOfDogs <= 0)
            {
                Console.WriteLine("El número de perros debe ser mayor que cero.");
                return;
            }
            
            // Get trip duration
            Console.Write("Ingrese la duración del viaje en días: ");
            double tripDuration = double.Parse(Console.ReadLine());
            
            if (tripDuration <= 0)
            {
                Console.WriteLine("La duración del viaje debe ser mayor que cero.");
                return;
            }
            
            // Calculate food needed
            double totalFoodGrams = DAILY_CONSUMPTION_GRAMS * numberOfDogs * tripDuration;
            double totalFoodKg = totalFoodGrams / GRAMS_PER_KG;
            
            // Display results
            Console.WriteLine("\n===== Resultados =====");
            Console.WriteLine($"Número de perros: {numberOfDogs}");
            Console.WriteLine($"Duración del viaje: {tripDuration} días");
            Console.WriteLine($"Consumo diario por perro: {DAILY_CONSUMPTION_GRAMS} gramos");
            Console.WriteLine($"Consumo diario total: {DAILY_CONSUMPTION_GRAMS * numberOfDogs} gramos");
            Console.WriteLine($"Alimento total necesario: {totalFoodGrams:F2} gramos ({totalFoodKg:F2} kilogramos)");
            
            // Recommendation
            double extraDays = 1.0; // Recommended to leave extra food for one additional day
            double recommendedFoodKg = (totalFoodGrams + (DAILY_CONSUMPTION_GRAMS * numberOfDogs * extraDays)) / GRAMS_PER_KG;
            
            Console.WriteLine("\n===== Recomendación =====");
            Console.WriteLine($"Se recomienda dejar alimento para {extraDays} día(s) adicional(es) por seguridad.");
            Console.WriteLine($"Cantidad recomendada: {recommendedFoodKg:F2} kilogramos");
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