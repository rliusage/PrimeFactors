using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator.Implementations
{
    public class ConsolePresenter : IPresenter
    {
        public void Present(Int64 number, IEnumerable<Int64> primeFactors)
        {
            string factors = string.Join(",", primeFactors.ToArray());
            Console.WriteLine("{0} has these prime factors: {1}", number, factors);
        }
    }
}
