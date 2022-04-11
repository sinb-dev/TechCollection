using System.Collections;

namespace TCCollections;
public class List : IEnumerable<object>
{
    object[] list = new object[10];
    int size = 0;
    

    public void Add(object obj)
    {
        if (obj == null) return;

        if (size == list.Length)
        {
            object[] newList = new object[list.Length * 10];
            for (int i= 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }
            list = newList;
        }
        list[size] = obj;
        size++;
    }
    public void Remove(object obj)
    {
        int idx = Find(obj);
        if (idx != -1)
        {
            for (int i = idx; i < list.Length-1; i++)
            {
                list[i] = list[i + 1];
            }
            list[size] = null;
            size--;
        }
    }
    public object? Get(int index) 
    {
        if (index >= 0 && index < size)
        {
            return list[index];
        }
        return null;
    }
    public bool Contains(object obj)
    {
        return Find(obj) != -1;
    }
    public int Find(object obj)
    {
        for (int i = 0; i < size; i++)
        {
            if (obj == list[i]) 
                return i;
        }
        return -1;
    }

    public IEnumerator<object> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int Count { get { return size; } }
}
