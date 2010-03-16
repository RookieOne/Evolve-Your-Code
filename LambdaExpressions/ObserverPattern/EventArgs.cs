using System;

namespace LambdaExpressions.ObserverPattern
{
    public class EventArgs<T> : EventArgs
    {
        public EventArgs(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}