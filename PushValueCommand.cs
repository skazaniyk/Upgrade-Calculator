class PushValueCommand : ICommand
{  
    private readonly Stack<Physical> _values;
    private readonly Physical _value;
        
    public PushValueCommand(Stack<Physical> values, Physical value) 
    {
        _values = values;
        _value = value;
    }
        
    public void Execute() => _values.Push(_value);
    public void Undo() => _values.Pop();
}