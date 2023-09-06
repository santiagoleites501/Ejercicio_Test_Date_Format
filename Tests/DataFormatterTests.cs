namespace Library.Tests;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Correctformat1()
    {
        string data ="06/12/2004";
        string spected ="2004-12-06";
        string auput = TestDateFormat.DateFormatter.ChangeFormat(data);
        Assert.AreEqual(spected, auput);
    }
    [Test]
    public void inCorrectformat1()
    {
        string data ="0612204";
        string spected ="2004-12-06";
        string auput = TestDateFormat.DateFormatter.ChangeFormat(data);
        Assert.AreNotEqual(spected, auput);
    }
    [Test]
    public void vacio()
    {
        string data ="";
        string spected = "";
        string auput = TestDateFormat.DateFormatter.ChangeFormat(data);
        Assert.AreEqual(spected, auput);
    }
}