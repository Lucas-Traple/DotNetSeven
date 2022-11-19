namespace DotNet7.Features;

public class RequiredFeature
{
    MyClass myClass = new()
    {
        MyProperty = "ergaer"
    };
}

class MyClass
{
    public required string MyProperty { get; set; }
}