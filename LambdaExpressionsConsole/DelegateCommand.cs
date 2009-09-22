using System;

namespace LambdaExpressionsConsole
{
    public class DelegateCommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            _action = action;
        }

        public void Execute()
        {
            _action.Invoke();
        }
    }
}