using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeFactorCalculator.Implementations;
using PrimeFactorCalculator.Interfaces;

namespace PrimeFactorsNunitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void SimpleCalculatorWithSmallNumber()
        {
            PrimeFactorsCalculator calculator = new SimpleCalculator();
            var primeFactors = calculator.Calculate(825);
            Assert.That(primeFactors.ToArray(), Is.EquivalentTo(new long[] { 5, 11, 5, 3 }));
        }

        [Test]
        public void SimpleCalculatorWithBigNumber()
        {
            PrimeFactorsCalculator calculator = new SimpleCalculator();
            var primeFactors = calculator.Calculate(284998);
            Assert.That(primeFactors.ToArray(), Is.EquivalentTo(new long[] { 2, 7, 20357 }));
        }
    }
}
