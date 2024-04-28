abstract class Physical
{
    public abstract string[] AvailableOperators { get; }
}

class Distance : Physical 
{
    public override string[] AvailableOperators => new [] {"+", "-", "*", "/", "(", ")"};
}

class Speed : Physical
{
    public override string[] AvailableOperators => new [] {"из", "-", "*", "/", "(", ")"};
} 

class Time : Physical
{
    public override string[] AvailableOperators => new [] {"из", "-", "*", "/", "(", ")"};
}

class Length : Physical { }
class Scalar : Physical { }