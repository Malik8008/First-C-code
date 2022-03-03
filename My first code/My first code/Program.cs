using System;

namespace My_first_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 1)
                Console.WriteLine("eded tekdir");
            else
                Console.WriteLine("eded cutdur");
        }
    }
}
