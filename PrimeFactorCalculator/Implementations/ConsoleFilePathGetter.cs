using PrimeFactorCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator.Implementations
{
    public class ConsoleFilePathGetter : IFilePathGetter
    {
        public string FilePath()
        {
            Boolean fileNotExists = true;
            String filePath = string.Empty;

            while(fileNotExists)
            {
                Console.WriteLine("Full path to file containing the numbers: ");

                filePath = Console.ReadLine();
                fileNotExists = !File.Exists(filePath);
            }

            return filePath;
        }
    }
}
