using System;
using System.Linq.Expressions;

namespace ExpressionTreeConsole
{
    public class ConsoleVisitor : ExpressionVisitor
    {
        public static void WriteToConsole(Expression e)
        {
            Console.WriteLine("Begin Visiting");

            new ConsoleVisitor().Visit(e);

            Console.WriteLine("Finished Visiting");
            Console.ReadLine();
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            Console.WriteLine("Node Type {0}", b.NodeType);                        
            return base.VisitBinary(b);
        }

        protected override Expression VisitParameter(ParameterExpression p)
        {
            Console.WriteLine("Parameter {0}", p.Name);
            return base.VisitParameter(p);
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            Console.WriteLine("Constant {0}", c.Value);
            return base.VisitConstant(c);
        }
    }
}