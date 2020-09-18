using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----START-----");
            TemplateCSV<User> user = new ConcreteUser();
            user.Read();
            Console.WriteLine("-----NEXT-----");
            TemplateCSV<Country> country = new ConcreteCountry();
            country.Read();
            Console.WriteLine("-----END-----");
        }
    }
}
