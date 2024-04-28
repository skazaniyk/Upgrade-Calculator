class Operator
{
    public string Name { get; }
    public Operator(string name) => Name = name;
}

interface ICommand
{
    void Execute();
    void Undo();
}