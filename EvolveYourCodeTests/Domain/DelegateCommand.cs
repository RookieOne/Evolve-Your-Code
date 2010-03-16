using System;

namespace EvolveYourCodeTests.Domain
{
    public class DelegateCommand : ICoffeeCommand
    {
        public DelegateCommand(Func<ICoffee, ICoffee> func)
        {
            _func = func;
        }

        readonly Func<ICoffee, ICoffee> _func;

        public ICoffee Execute(ICoffee coffee)
        {
            return _func(coffee);
        }
    }
}