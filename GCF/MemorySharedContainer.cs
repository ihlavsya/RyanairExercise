using System.Collections.Generic;

namespace GCF;

// i made everything static because that`s how i understood "shared" in the description
// also i used existing implementation of lists, because from the descr i gathered that the point in synchronization
// and not in actual implementation of this type (which can be done through arrays, as it`s done for built-in list)
public static class MemorySharedContainer
{
    private static List<string> _elements = new();
    private static readonly object _contatiner_lock = new object();

    public static void Add(IEnumerable<string> items)
    {
        lock (_contatiner_lock)
        {
            _elements.AddRange(items);
        }
    }
    
    public static IEnumerable<string> Get()
    {
        string[] result;
        lock (_contatiner_lock)
        {
            result = new string[_elements.Count];
            _elements.CopyTo(result);
            _elements.Clear();
        }

        return result;
    }
}