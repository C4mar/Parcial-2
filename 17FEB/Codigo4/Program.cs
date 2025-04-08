using System;

class Program{
    static void Main() {
        Console.WriteLine("Ingresa el nombre ");
        
        string? nombre = Console.ReadLine();
        Console.WriteLine("Ingresa el apellido");
        string? apellido = Console.ReadLine();
        
        Console.WriteLine("El primer orden es: "+ nombre + " "+ apellido);
        Console.WriteLine("El segundo orden es: "+ apellido +" " + nombre);
    }
 } 