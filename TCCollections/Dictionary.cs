namespace TCCollections;
public class Dictionary
{
    KeyValuePair[] pairs = new KeyValuePair[10];

    class KeyValuePair 
    {
        string Key {get;set;} = "";
        object Value {get;set;} = new object();
    }

    public void Add(string key, object value)
    {
        throw new NotImplementedException();
    }
    public void Remove(string key)
    {
        throw new NotImplementedException();
    }
    public bool ContainsKey(string key)
    {
        throw new NotImplementedException();
    }
    public bool ContainsValue(string key)
    {
        throw new NotImplementedException();
    }
    public int Count {get;}

}
