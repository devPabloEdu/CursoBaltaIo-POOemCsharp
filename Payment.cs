namespace Payments
{
    public partial class Payment
    {
        public class Pagamento{

        }
        public interface IPagamento
        {
             DateTime Vencimento { get; set; }

             void Pagar(double valor);
        }
    }
}