using System;

class Oxxo{
     public decimal totalCompra;
     public decimal montoPagado;

     public void Pedido(decimal Pagado, decimal Compra){
        
        totalCompra = Compra;
        montoPagado = Pagado;
    
        if(totalCompra > montoPagado)
        {
            Console.WriteLine("El monto pagado es insuficiente.");
        }
        else
        {
            decimal vuelto = montoPagado - totalCompra;
            Console.WriteLine("El vuelto es: " + vuelto);

        }
    }
}

class Program
{
    static void Main()
    {
        Oxxo Cambio = new Oxxo();
        Console.Write("Ingrese el total de la compra: ");
        decimal Compra = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el monto pagado por el cliente: ");
        decimal Pagado = Convert.ToDecimal(Console.ReadLine());
        Cambio.Pedido(Pagado,Compra);
    }
}        