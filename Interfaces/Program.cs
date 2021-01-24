using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Student student = new Student();
            student.Id = 1;
            student.FirstName = "Murat";
            student.LastName = "Ertürk";
            student.Departman = "Bass";
            personManager.Add(new Customer { Id = 1, FirstName = "Elif", LastName = "Ertürk", Address = "İstanbul" });
            personManager.Add(student);
        }
    }

    interface IPerson //soyut --burada özellik tutmak için kullanıyoruz.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson //somut
    {
        public int Id { get; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }

        public string Address { get; set; }
    }

    class Student : IPerson //somut
    {
        public int Id { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }
        public string Departman { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
