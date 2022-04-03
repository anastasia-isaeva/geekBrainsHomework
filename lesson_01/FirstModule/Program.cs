using System;

namespace FirstModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please: ");
            string name = Console.ReadLine();
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine($"Hello , {name}!");
            Console.Write($"Today is , {DateTime.Today}");
        }
    }
}
