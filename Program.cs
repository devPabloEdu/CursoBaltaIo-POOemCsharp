using System;
namespace POOemCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var pagamentoBoleto = new PagamentoBoleto();
            // pagamentoBoleto.Pagar();
            // pagamentoBoleto.Vencimento = DateTime.Now;
            // pagamentoBoleto.NumeroBoleto = "123";
            var pagamento = new Pagamento();
            pagamento.Vencimento = DateTime.Now;
            //OBJETO SEMPRE É UM TIPO DE REFERENCIA

            Console.WriteLine(pagamento.Vencimento);
        }
    }

    class Pagamento
    {
        //propriedades = variaveis
        public DateTime Vencimento;
        //metodos = funções
        public virtual void Pagar(){}

        public override string ToString()
        {
            return Vencimento.ToString("dd/mm/yy");
        }
    }

    // class PagamentoBoleto : Pagamento
    // {
    //     public string NumeroBoleto;

    //     public override void Pagar()
    //     {
    //        //regra do boleto
    //     }

    // }

    
    // class PagamentoCartao : Pagamento
    // {
    //     public string NumeroCartao;

    //     public override void Pagar()
    //     {
    //        //regra do cartão
    //     }
    // }
    
}