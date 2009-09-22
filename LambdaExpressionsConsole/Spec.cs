using System;

namespace LambdaExpressionsConsole
{
    public class Spec<T>
    {
        private readonly Func<T, bool> _func;

        public Spec(Func<T, bool> func)
        {
            _func = func;
        }

        public bool IsSatisfiedBy(T item)
        {
            return _func.Invoke(item);
        }
    }
}