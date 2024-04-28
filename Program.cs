class Program
{
    static void Main()
    {
        var runner = new CalculatorUpgradeRunner();
            
        // Использование калькулятора
        runner.PushOperator(new Operator("("));
        runner.PushValue(new Distance());
        runner.PushOperator(new Operator("из"));
        runner.PushValue(new Speed());
        runner.PushOperator(new Operator(","));
        runner.PushValue(new Time());
        runner.PushOperator(new Operator(")"));
        runner.Compute();
            
        runner.Undo();
        // ...
    }
}