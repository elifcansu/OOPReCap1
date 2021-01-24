using System;

namespace OOPReCap1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "İstanbul";
            customer.FirstName = "Elif"; //bir classın prop eşitlendiği zaman bu proptaki set bloğunu çalıştırır.
            customer.LastName = "Ertürk";

            Customer customer1 = new Customer
            {
                Id=2,City="İstanbul",FirstName="Murat",LastName="Ertürk"
            };

            Console.WriteLine(customer1.FirstName); //burada firstname al demek get bloğu çalışır.
        }
    }
}
