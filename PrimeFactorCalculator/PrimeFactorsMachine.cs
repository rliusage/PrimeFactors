using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator
{
    public class PrimeFactorsMachine
    {
        public IFilePathGetter FilePathGetter { get; set; }
        public IFileParser FileParser { get; set; }
        public PrimeFactorsCalculator Calculator { get; set; }
        public IPresenter Presenter { get; set; }

        public void Process()
        {
            String filePath = FilePathGetter.FilePath();
            var allNumbers = FileParser.Parse(filePath);

            var results = allNumbers.Select(number => new { Number = number, PrimeFactors = Calculator.Calculate(number) });

            foreach (var result in results)
            {
                Presenter.Present(result.Number, result.PrimeFactors);
            }
        }
    }
}
