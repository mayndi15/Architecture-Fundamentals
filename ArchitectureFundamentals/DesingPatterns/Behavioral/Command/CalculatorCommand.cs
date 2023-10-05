namespace Architecture_Fundamentals.DesingPatterns.Behavioral.Command
{
    internal class CalculatorCommand : Commander
    {
        private char _operators;
        private int _value;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char operators, int value)
        {
            _calculator = calculator;
            _operators = operators;
            _value = value;
        }

        public char Operators
        {
            set => _operators = value;
        }

        public int Operand
        {
            set => _value = value;
        }

        public override void Execute()
        {
            _calculator.Operation(_operators, _value);
        }

        public override void Undo()
        {
            _calculator.Operation(Undo(_operators), _value);
        }

        private static char Undo(char operators)
        {
            switch (operators)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }
    }
}