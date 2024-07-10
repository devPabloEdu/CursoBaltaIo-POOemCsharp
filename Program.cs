using System;
namespace POOemCsharp
{
    class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
        static void Main(string[] args)
        {
            //delegades => Anonymous Methods
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(20);
        }
    }
    
    public class Pagamento{
        public delegate void Pagar(double valor);
    }
}