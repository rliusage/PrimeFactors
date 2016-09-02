using NUnit.Framework;
using PrimeFactorCalculator;
using PrimeFactorCalculator.Implementations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsNunitTests
{
    [TestFixture]
    public class IntegrationTest
    {
        Int64[] _arrayOfLong = { 128, 3600, 256, 999, 369, 128 };
        string _fileName = Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "test.txt");

        [OneTimeSetUp]
        public void Init()
        {
            string fileContent = string.Join("\n", _arrayOfLong);
            File.WriteAllText(_fileName, fileContent);
        }
        [Test]
        public void CalculatePrimesFactorAndDisplayInConsole()
        {
            using(StringReader reader = new StringReader(_fileName))
            {
                Console.SetIn(reader);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    PrimeFactorsMachine machine = new PrimeFactorsMachine
                    {
                        FilePathGetter = new ConsoleFilePathGetter(),
                        FileParser = new ReadLinesFileParser(),
                        Calculator = new SimpleCalculator(),
                        Presenter = new ConsolePresenter()
                    };
                    machine.Process();

                    StringBuilder expected = new StringBuilder();
                    expected.Append("Full path to file containing the numbers: ")
                            .Append(Environment.NewLine)
                            .Append("128 has these prime factors: 2,2,2,2,2,2,2")
                            .Append(Environment.NewLine)
                            .Append("3600 has these prime factors: 2,2,2,2,3,3,5,5")
                            .Append(Environment.NewLine)
                            .Append("256 has these prime factors: 2,2,2,2,2,2,2,2")
                            .Append(Environment.NewLine)
                            .Append("999 has these prime factors: 3,3,3,37")
                            .Append(Environment.NewLine)
                            .Append("369 has these prime factors: 3,3,41")
                            .Append(Environment.NewLine)
                            .Append("128 has these prime factors: 2,2,2,2,2,2,2")
                            .Append(Environment.NewLine);

                        Assert.That(sw.ToString(), Is.EqualTo(expected.ToString()));
                }
            }
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            File.Delete(_fileName);
        }
    }
}
