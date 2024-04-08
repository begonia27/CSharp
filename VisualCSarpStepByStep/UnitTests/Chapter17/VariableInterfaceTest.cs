using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]

public class VariableInterfaceTests
{
    [TestMethod]
    public void VariableInterfaceTest()
    {
        Horse<string> stringHorse = new Horse<string>();
        IAnimal<string> storedStringAnimal = stringHorse;

        storedStringAnimal.SetData("Hello");
        
        Assert.AreEqual("Hello",storedStringAnimal.GetData());
    }

    [TestMethod]
    public void VariableInterfaceCovariance()
    {
        Cat<string> stringCat = new Cat<string>();
        IStoreCat<string> storedStringAnimal = stringCat;
        IRetrieveCat<string> retrievedStringCat = stringCat;
        
        storedStringAnimal.SetData("Hello, World");
        
        Assert.AreEqual("Hello, World", retrievedStringCat.GetData());
    }
    
    [TestMethod]
    public void InstanceCovariance()
    {
        Cat<string> stringCat = new Cat<string>();
        IStoreCat<string> storedStringAnimal = stringCat;
        IRetrieveCat<object> retrievedObjectCat = stringCat;
        
        storedStringAnimal.SetData("Lucky");
        
        Assert.AreEqual("Lucky", retrievedObjectCat.GetData());
    }
}
