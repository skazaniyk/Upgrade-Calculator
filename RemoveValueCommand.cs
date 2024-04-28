class RemoveValueCommand : ICommand
{
    private readonly Stack<Physical> _values;
    private Physical _removedValue;

    public RemoveValueCommand(Stack<Physical> values) => _values = values;
        
    public void Execute() => _removedValue = _values.Pop(); 
    public void Undo() => _values.Push(_removedValue);
}