using System;
using System.Collections.Generic;
using System.Linq;

namespace GCF;

public static class GCFClass
{
// i personally wouldn`t use double as type, because we interested in division without remainders,
// doubles would only introduce unnecessary casting and rounding

    //O(log(min(firstNumber, secondNumber)) 
    public static uint GetGCF(uint firstNumber, uint secondNumber)
    {
        if (firstNumber == 0 || secondNumber == 0)
        {
            throw new ArgumentException("Incorrect input, you cannot use 0");
        }

        if (firstNumber < secondNumber)
        {
            (firstNumber, secondNumber) = (secondNumber, firstNumber);
        }

        var previousDivisor = firstNumber;
        var remainder = secondNumber;
        while (remainder > 0)
        {
            var newRemainder = previousDivisor % remainder;
            (previousDivisor, remainder) = (remainder, newRemainder);
        }

        return previousDivisor;
    }

    // O(number)
    private static List<uint> GetFactors(uint number)
    {
        var factors = new List<uint>() {number};
        uint max = number - 2;

        for (uint factor = max; factor > 0; --factor)
        {
            if (number % factor == 0)
            {
                factors.Add(factor);
            }
        }

        return factors;
    }

    public static uint GetKthGreatestFactor(int k, IEnumerable<uint> numbers)
    {
        // maybe add info about fibonacci numbers
        // O(N*log(min(x1, x2)) 
        // where N is Count in numbers
        uint gcf = numbers.Aggregate((x1, x2) => GetGCF(x1, x2));
        // + O(gcf)
        // = O(N*log(min(x1, x2)) 
        List<uint> factors = GetFactors(gcf);
        // + O(1)
        int kIndex = k - 1;
        uint result = factors[kIndex];
        // = O(N*log(min(x1,x2)))
        return result;
    }
}