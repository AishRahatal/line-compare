using System;
namespace line_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison program!");

            Calculate_length obj = new Calculate_length();
            obj.get_length();
            Console.ReadKey();
        }
    }
}
