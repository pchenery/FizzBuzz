using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_Returns_Fizz_When_Only_Divisible_By_3()
        {
            Assert.That(FizzBuzz.GetValue(3), Is.StringMatching("Fizz"));
        }

        [Test]
        public void FizzBuzz_Returns_Buzz_When_Only_Divisible_By_5()
        {
            Assert.That(FizzBuzz.GetValue(5), Is.StringMatching("Buzz"));
        }

        [Test]
        public void FizzBuzz_Returns_Fizz_When_Only_Divisible_By_11()
        {
            Assert.That(FizzBuzz.GetValue(11), Is.StringMatching("Bong"));
            Assert.That(FizzBuzz.GetValue(143), Is.StringMatching("Fezz"));
        }

        [Test]
        public void FizzBuzz_Returns_FizzBuzz_When_Divisible_By_3_And_5()
        {
            Assert.That(FizzBuzz.GetValue(15), Is.StringMatching("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_Returns_Fizz_When_Divisible_By_3_And_7()
        {
            Assert.That(FizzBuzz.GetValue(21), Is.StringMatching("FizzBang"));
        }
    }
}
