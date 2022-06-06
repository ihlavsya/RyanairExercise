using System;
using System.Collections.Generic;
using System.Linq;
using GCF;
using NUnit.Framework;

namespace GCFTests;

public class MemorySharedContainerTests
{
    [Test]
    public void AddWhenSourceIsNull()
    {
        var container = new MemorySharedContainer();
        
        Assert.Throws<ArgumentNullException>(() => container.Add(null), "Cannot be null");
    }

    [Test]
    public void AddWhenSourceIsEmpty()
    {
        var expected = new List<string>();
        var container = new MemorySharedContainer();
        container.Add(expected);

        var actual = container.Get().ToList();

        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void GetWhenCollectionIsEmpty()
    {
        var expected = new List<string>();
        var container = new MemorySharedContainer();

        var actual = container.Get().ToList();

        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Add_GetTest()
    {
        var expected = new List<string>
        {
            "1",
            "2",
            "3"
        };
        var container = new MemorySharedContainer();
        
        container.Add(expected);
        var actual = container.Get().ToList();

        CollectionAssert.AreEqual(expected, actual);
    }
}