using System.Collections;

namespace TCCollections;
public class List : IEnumerable<object>
{
    object[] list = new object[10];

    public void Add(object obj)
    {
        throw new NotImplementedException();
    }
    public void Remove(object obj)
    {
        throw new NotImplementedException();
    }
    public object? Get(int index) 
    {
        throw new NotImplementedException();
    }
    public bool Contains(object obj)
    {
        throw new NotImplementedException();
    }
    public int Find(object obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<object> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int Count {get;}
}
