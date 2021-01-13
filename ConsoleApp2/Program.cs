using FizzBuzzLibrary;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbl = new FizzBuzz_Generator();
            var firstRule = 3;
            var secondRule = 7;
            var upperBound = 100;

            foreach (string item in fbl.GenerateData(firstRule, secondRule, upperBound))
            {
                Console.WriteLine(item);
            }
        }
    }
}
