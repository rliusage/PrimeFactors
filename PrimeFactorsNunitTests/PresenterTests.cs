using NUnit.Framework;
using PrimeFactorCalculator.Implementations;
using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsNunitTests
{
    [TestFixture]
    public class PresenterTests
    {
        [Test]
        public void ConsolePresenterTest()
        {
            Int64 number = 369;
            Int64[] primeFactors = new Int64[] { 3, 3, 41};
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                IPresenter presenter = new ConsolePresenter();
                presenter.Present(number, primeFactors);
                string expected = string.Format("{0} has these prime factors: {1}{2}", number, "3,3,41",Environment.NewLine);

                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }
    }
}
