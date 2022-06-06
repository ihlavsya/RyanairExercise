using System;
using System.Collections.Generic;
using GCF;
using NUnit.Framework;

namespace GCFTests;

public class GCFTests
{
    [Test]
    public void GetKthGreatestFactor_Returns12()
    {
        var list = new List<uint>()
            {48, 36, 12};
        var expected1 = 12;

        var actual1 = GCFClass.GetKthGreatestFactor(1, list);

        Assert.AreEqual(expected1, actual1);
    }
    
    [Test]
    public void GetGCF_ThrowsException_IfArgumentIs0()
    {
        uint firstNumber = 1;
        uint secondNumber = 0;

        Assert.Throws<ArgumentException>(() => GCFClass.GetGCF(firstNumber, secondNumber));
    }
    
    [Test]
    public void GetGCF_Returns3_When3And9()
    {
        uint firstNumber = 3;
        uint secondNumber = 9;
        uint expected = 3;
        
        uint actual = GCFClass.GetGCF(firstNumber, secondNumber);

        Assert.AreEqual(expected, actual);
    }
}