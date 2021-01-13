using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FizzBuzzLibrary.Tests
{
    [TestClass()]
    public class FizzBuzz_Generator_Tests
    {

        [TestMethod()]
        public void GenerateData_RulesReturnFizzBuzzWhenIndexIsProductMinusOne_True()
        {
            var fbGenerator = new FizzBuzz_Generator();
            var firstRule = 3;
            var secondRule = 7;
            var upperBound = int.MaxValue;
            var expectedResult = "FizzBuzz";

            var result = fbGenerator.GenerateData(firstRule, secondRule, upperBound);

            var productOfFirstTimesSecond = firstRule * secondRule;

            //  Indexing starts at 0, so if your rules are 3 and 5, then you would want index of 15-1 or 14.
            var idx = result.ElementAt(productOfFirstTimesSecond - 1);

            Assert.IsTrue(string.Equals(idx, expectedResult));
        }

        [TestMethod()]
        public void GenerateData_RulesDoNotReturnFizzBuzzWhenIndexIsProduct_True()
        {
            var fbGenerator = new FizzBuzz_Generator();
            var firstRule = 9;
            var secondRule = 15;
            var upperBound = int.MaxValue;
            var expectedResult = "FizzBuzz";

            var result = fbGenerator.GenerateData(firstRule, secondRule, upperBound);

            var productOfFirstTimesSecond = firstRule * secondRule;

            //  Indexing starts at 0, so if your rules are 3 and 5, then you would want index of 15-1 or 14.
            var idx = result.ElementAt(productOfFirstTimesSecond);

            Assert.IsTrue(!string.Equals(idx, expectedResult));
        }

        [TestMethod()]
        public void GenerateData_FirstRuleReturnFizz_True()
        {
            var fbGenerator = new FizzBuzz_Generator();
            var firstRule = 3;
            var secondRule = 7;
            var upperBound = int.MaxValue;
            var expectedResult = "Fizz";

            var result = fbGenerator.GenerateData(firstRule, secondRule, upperBound);

            //  Indexing starts at 0, so if your rules are 3 and 5, then you would want index of 15-1 or 14.
            var idx = result.ElementAt(firstRule - 1);

            Assert.IsTrue(string.Equals(idx, expectedResult));
        }

        [TestMethod()]
        public void GenerateData_SecondRuleReturnBuzz_True()
        {
            var fbGenerator = new FizzBuzz_Generator();
            var firstRule = 6;
            var secondRule = 14;
            var upperBound = int.MaxValue;
            var expectedResult = "Buzz";

            var result = fbGenerator.GenerateData(firstRule, secondRule, upperBound);

            //  Indexing starts at 0, so if your rules are 3 and 5, then you would want index of 15-1 or 14.
            var idx = result.ElementAt(secondRule - 1);

            Assert.IsTrue(string.Equals(idx, expectedResult));
        }
    }
}