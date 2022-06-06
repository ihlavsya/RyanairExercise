using System;
using System.Collections.Generic;

namespace GCF;

// i made everything static because that`s how i understood "shared" in the description
// also i used existing implementation of lists, because from the descr i gathered that the point in synchronization
// and not in actual implementation of this type (which can be done through arrays, as it`s done for built-in list)
public class MemorySharedContainer
{
    private List<string> _elements = new();
    private static readonly object _contatinerLock = new object();

    public void Add(IEnumerable<string> items)
    {
        if (items == null)
        {
            throw new ArgumentNullException(null,"Cannot be null");
        }
        lock (_contatinerLock)
        {
            _elements.AddRange(items);
        }
    }
    
    public IEnumerable<string> Get()
    {
        lock (_contatinerLock)
        {
            string[] result = new string[_elements.Count];
            _elements.CopyTo(result);
            _elements.Clear();
            return result;
        }
    }
}