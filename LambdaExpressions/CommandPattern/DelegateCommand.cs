using System;

namespace LambdaExpressions.CommandPattern
{
    public class DelegateCommand
    {
        public DelegateCommand(Action action)
        {
            _action = action;
        }

        readonly Action _action;

        public void Execute()
        {
            _action.Invoke();
        }
    }
}