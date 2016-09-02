﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorCalculator.Interfaces
{
    public interface IFileParser
    {
        IEnumerable<Int64> Parse(string filePath);
    }
}
