using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLibrary
{
    public class FizzBuzz_Generator
    {
        public IEnumerable<string> GenerateData(int firstRule = 3, int secondRule = 5, int upperBound = 100)
        {
            // how can you get to return max value without running into limbo
            // add divisors/rules
            // unit test

            // BONUS
            // build a powershell build script, (produce the exe file)
            // upload it to github

            return Enumerable.Range(1, upperBound)
                              .Select(i => JasonTest(i, firstRule, secondRule));
        }

        private string JasonTest(int i, int firstRule = 3, int secondRule = 5)
        {
            var fizz = "Fizz";
            var buzz = "Buzz";
            var fizzBuzz = fizz + buzz;

            return (i % firstRule == 0 && i % secondRule == 0) ? fizzBuzz :
                    (i % secondRule == 0) ? buzz :
                    (i % firstRule == 0) ? fizz :
                    i.ToString();
        }
    }
}
