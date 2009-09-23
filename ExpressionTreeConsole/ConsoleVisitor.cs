using System;
using System.Linq.Expressions;

namespace ExpressionTreeConsole
{
    public class ConsoleVisitor : ExpressionVisitor
    {
        protected override Expression VisitParameter(ParameterExpression p)
        {
            Console.WriteLine("Parameter {0}", p.Name);
            return base.VisitParameter(p);
        }
    }
}