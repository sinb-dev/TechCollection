using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class List_Find
{
    [Fact]
    public void BasicFind()
    {
        List list = new List();
        list.Add("Hello");
        list.Add("Beautiful");
        list.Add("World");

        Assert.Equal(0,list.Find("Hello")); //Hello is on index 0
        Assert.Equal(1, list.Find("Beautiful")); //Beautiful is on index 1
        Assert.Equal(2, list.Find("World")); //World is on index 2
    }
    [Fact]
    public void BasicFindAfterRemove()
    {
        List list = new List();
        list.Add("Hello");
        list.Add("Beautiful");
        list.Add("World");

        list.Remove("Beautiful");
        Assert.Equal(0, list.Find("Hello")); //Hello is on index 0
        Assert.Equal(1, list.Find("World")); //World is on index 1
    }
    [Fact]
    public void BasicNonExistingIsMinusOne()
    {
        List list = new List();
        list.Add("Hello");
        list.Add("Beautiful");
        list.Add("World");

        Assert.Equal(-1, list.Find("W0rld")); //W0rld is not in list -1
    }
}