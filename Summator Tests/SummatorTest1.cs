using NUnit.Framework;

namespace Summator
{
    public class Tests
    {
        [Test]
        public void Test_SumTwoPositiveNumbers()
        {

            int result = Summator.Sum (new int[] { 5, 7 });

            Assert.That(result ==12);
        }
        [Test]
        public void Test_SumOnePositiveNumber()
        {

            int result = Summator.Sum(new int[] { 5, });

            Assert.That(result == 5);
        }
        [Test]
        public void Test_SumTwoNegativeNumbers()
        {

            int result = Summator.Sum(new int[] { -5, -7 });

            Assert.That(result == -12);
        }
        [Test]
        public void Test_SumOneNegativeumber()
        {

            int result = Summator.Sum(new int[] { -5 });

            Assert.That(result == -5);
        }
        [Test]
        public void Test_SumOnePositiveNumberAndZero()
        {

            int result = Summator.Sum(new int[] { 5, 0 });

            Assert.That(result == 5);
        }
       
    }
}