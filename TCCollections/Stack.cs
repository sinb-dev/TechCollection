namespace TCCollections;
public class Stack
{
    object[] list = new object[10];
    int top = 0;
    public void Push(object obj)
    {
        list[top] = obj;
        return;
        throw new NotImplementedException();
    }
    public object Pop()
    {
        if (list.Length > 0 && top+1 == list.Length)
        return list[top];
        throw new NotImplementedException();
    }
    public object Top()
    {
        throw new NotImplementedException();
    }
    public bool Contains(object obj)
    {
        throw new NotImplementedException();
    }
    public int Count {get;}

}
