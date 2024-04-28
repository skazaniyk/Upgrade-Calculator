class CalculatorUpgradeRunner
{
    private readonly Stack<ICommand> _commands = new();
    private readonly Stack<Operator> _operators = new();  
    private readonly Stack<Physical> _values = new();

    public void PushOperator(Operator op)
    {
        var command = new PushOperatorCommand(_operators, op);
        command.Execute();
        _commands.Push(command);
    }
        
    public void PushValue(Physical value)
    {      
        var command = new PushValueCommand(_values, value);
        command.Execute();
        _commands.Push(command);
    }

    public void ChangeValue(Physical newValue)
    {
        var command = new ChangeValueCommand(_values, newValue);  
        command.Execute();
        _commands.Push(command);
    }
        
    public void RemoveValue()
    {
        var command = new RemoveValueCommand(_values);
        command.Execute();
        _commands.Push(command);
    }

    public void Compute()
    {
        var command = new ComputeCommand();
        command.Execute();  
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count > 0)
        {
            var lastCommand = _commands.Pop();
            lastCommand.Undo();
        }
    }
}