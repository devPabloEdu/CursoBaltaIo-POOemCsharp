using System;
namespace POOemCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var personA = new Person(1, "Pablo Eduardo");
            var personB = new Person(1, "Pablo Eduardo");
            Console.WriteLine(personA.Equals(personB));

            // var pagamentoBoleto = new PagamentoBoleto();
            // pagamentoBoleto.Pagar();
            // pagamentoBoleto.Vencimento = DateTime.Now;
            // pagamentoBoleto.NumeroBoleto = "123";
            // var pagamento = new PagamentoBoleto();
            // pagamento.Vencimento = DateTime.Now;
            //OBJETO SEMPRE É UM TIPO DE REFERENCIA

            // Console.WriteLine(pagamento.Vencimento);
        }
    }
    public class Person : IEquatable<Person>
    {
        public Person(int id, string nome)
        {
            Id = id;
            Nome = nome;
            
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Person? other)
        {
            return Id == other.Id;
            return Nome == other.Nome;
        }
    }
    // public class Personal : Person
    // {
    //     public string CPF { get; set; }
    // }

    // public class Corporate : Person
    // {
    //     public string CNPJ { get; set; }
    // }
        //temos em c# os seguintes modificadores : private, protected, internal e public.
    // public abstract class Pagamento
    // {
    //     public DateTime dataPagamento { get; set; }
    //     public Pagamento()
    //     {
    //         Console.WriteLine("iniciando o pagamento.");
    //         dataPagamento = DateTime.Now;
            
    //     }
    //     public DateTime Vencimento { get; set; }

    //     private DateTime _DataDePagamento;
    //     public DateTime MyProperty
    //     {
    //         get { return _DataDePagamento; }
    //         set { _DataDePagamento = value; }
    //     }
        
    //     public virtual void Pagar(){}

    //     public virtual void Pagar(string numero){}


    //     public override string ToString()
    //     {
    //         return Vencimento.ToString("dd/mm/yy");
    //     }
    // }

    //  class PagamentoBoleto : Pagamento
    // {
    //     public string NumeroBoleto;

    //    public override void Pagar()
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