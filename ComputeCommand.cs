class ComputeCommand : ICommand
{
    public void Execute()
    {
        var result = EvaluateExpression();
        _values.Clear();
        _operators.Clear();
        _values.Push(result);
    }
    
    public void Undo() { /* Отмена вычисления */ }  
}