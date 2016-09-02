using NUnit.Framework;
using PrimeFactorCalculator.Implementations;
using PrimeFactorCalculator.Interfaces;
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
    public class FileParserTests
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
        public void ReadLinesFileParserTest()
        {
            IFileParser fileParser = new ReadLinesFileParser();
            Assert.That(fileParser.Parse(_fileName), Is.EquivalentTo(_arrayOfLong));
        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            File.Delete(_fileName);
        }
    }
}
