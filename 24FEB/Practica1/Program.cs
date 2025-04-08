using System;
public class Banco{
    public static int NumeroClientes(int n){
        if (n == 0){
            return 0;
        }
        else{
            return 1 + NumeroClientes(n-1);
        }
    }
    public static double SaldoTotal(int n, double saldo){
        if (n == 0){
            return saldo;
        }
        else{
            return saldo + SaldoTotal(n-1, saldo);
        }
    }
}   
class Program
{
    
    static void Main()
    {
        Console.WriteLine("Ingresa la cantidad de clientes:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El numero de clientes es: {Banco.NumeroClientes(n)}");
        Console.WriteLine("Ingresa el saldo de los clientes:");
        double saldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"El saldo total es: {Banco.SaldoTotal(n,saldo)}");
    }
}