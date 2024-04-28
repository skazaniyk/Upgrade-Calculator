class PushOperatorCommand : ICommand
{
    private readonly Stack<Operator> _operators;
    private readonly Operator _operator;

    public PushOperatorCommand(Stack<Operator> operators, Operator @operator)
    {
        _operators = operators;
        _operator = @operator;
    }
        
    public void Execute() => _operators.Push(_operator);
    public void Undo() => _operators.Pop();
}