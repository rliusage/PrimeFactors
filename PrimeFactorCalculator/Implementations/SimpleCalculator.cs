using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator.Implementations
{
    public class SimpleCalculator : PrimeFactorsCalculator
    {
        //copied from https://en.wikipedia.org/wiki/Trial_division
        public override IEnumerable<long> Calculate(long number)
        {
            List<Int64> primeFactors = new List<Int64>();

            if(number >=2)
            {
                var primeSieve = PrimeSieve(number);
                foreach (var prime in primeSieve)
                {
                    if (prime * prime > number) break;
                    while (number % prime == 0)
                    {
                        primeFactors.Add(prime);
                        number = Convert.ToInt64(Math.Floor(number / prime / 1.0));
                    }
                }
                if (number > 1)
                {
                    primeFactors.Add(number);
                }
            }
            
            return primeFactors;
        }
    }
}
