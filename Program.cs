using System;
namespace POOemCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Name ="pablo";
            Console.WriteLine(customer.Name);
        }

        struct Customer
        {
            public string Name;
        }
    }
    
}