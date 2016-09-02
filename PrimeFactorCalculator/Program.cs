using PrimeFactorCalculator.Implementations;
using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactorsMachine machine = new PrimeFactorsMachine
            {
                FilePathGetter = new ConsoleFilePathGetter(),
                FileParser = new ReadLinesFileParser(),
                Calculator = new SimpleCalculator(),
                Presenter = new ConsolePresenter()
            };
            machine.Process();
        }
    }
}
