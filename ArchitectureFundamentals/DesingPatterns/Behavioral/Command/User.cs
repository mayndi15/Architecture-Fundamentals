namespace Architecture_Fundamentals.DesingPatterns.Behavioral.Command
{
    public class User
    {
        // Initializers
        private readonly Calculator _calculator = new();
        private readonly List<Commander> _commands = new();
        private int _total;

        public void Add(char operators, int value)
        {
            Commander command = new CalculatorCommand(_calculator, operators, value);
            command.Execute();

            _commands.Add(command);
            _total++;
        }

        public void Return(int levels)
        {
            Console.WriteLine("\n---- Return {0} levels ", levels);

            for (var i = 0; i < levels; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            for (var i = 0; i < levels; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Undo();
            }
        }
    }
}