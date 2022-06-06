using System.Collections.Generic;
using System.Linq;
using GCF;
using NUnit.Framework;

namespace GCFTests;

public class MemorySharedContainerTests
{
    [Test]
    public void Add_GetTest()
    {
        var expected = new List<string>
        {
            "1",
            "2",
            "3"
        };
        MemorySharedContainer.Add(expected);
        var actual = MemorySharedContainer.Get().ToList();

        Assert.AreEqual(expected, actual);
    }
}