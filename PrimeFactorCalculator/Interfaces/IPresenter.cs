using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator.Interfaces
{
    public interface IPresenter
    {
        void Present(Int64 number, IEnumerable<Int64> primeFactors);
    }
}
