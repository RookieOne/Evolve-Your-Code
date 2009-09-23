using System;
using System.Linq.Expressions;

namespace Expressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1 + 1
            ConstantExpression one = Expression.Constant(1);
            ConstantExpression oneByAnotherName = Expression.Constant(1);

            BinaryExpression add = Expression.Add(one, oneByAnotherName);
            Expression<Func<int>> expression = Expression.Lambda<Func<int>>(add);

            int result = expression.Compile().Invoke();
            Console.WriteLine("Result {0}", result); // is 2


            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}