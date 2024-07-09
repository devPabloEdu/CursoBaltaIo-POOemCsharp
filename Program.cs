using System;
namespace POOemCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";
            var pagamento = new Pagamento();
            pagamento.Vencimento = DateTime.Now;
            //OBJETO SEMPRE É UM TIPO DE REFERENCIA

        }
    }

    class Pagamento
    {
        //propriedades = variaveis
        public DateTime Vencimento;
        //metodos = funções
        public void Pagar(){}
    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;
    }

    
    class PagamentoCartao : Pagamento
    {
        public string NumeroCartao;
    }
    
}