using System;

namespace LambdaExpressions.ObserverPattern
{
    public class Subject
    {
        public Action<int> OnFoo;
        public event EventHandler<EventArgs<int>> FooEvent = delegate { };
    }
}