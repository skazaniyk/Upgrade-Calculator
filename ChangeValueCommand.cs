class ChangeValueCommand : ICommand
{
    private readonly Stack<Physical> _values;
    private readonly Physical _newValue;
    private Physical _oldValue;
        
    public ChangeValueCommand(Stack<Physical> values, Physical newValue)
    {
        _values = values;
        _newValue = newValue;
    }

    public void Execute()
    {
        _oldValue = _values.Pop();
        _values.Push(_newValue);
    }

    public void Undo() 
    {
        _values.Pop();
        _values.Push(_oldValue);
    }
}