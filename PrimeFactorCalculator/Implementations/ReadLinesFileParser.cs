using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator.Implementations
{
    public class ReadLinesFileParser : IFileParser
    {
        public IEnumerable<long> Parse(string filePath)
        {
            var allNumbers = File.ReadLines(filePath).Select(numberText => Int64.Parse(numberText));
            return allNumbers;
        }
    }
}
