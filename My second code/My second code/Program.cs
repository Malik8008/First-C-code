using System;

namespace My_second_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cavab:");
            if (number > number2)
                Console.WriteLine(number);
            else if (number < number2)
                Console.WriteLine(number2);
            else
                Console.WriteLine("Beraberdir");



        }
    }
}
