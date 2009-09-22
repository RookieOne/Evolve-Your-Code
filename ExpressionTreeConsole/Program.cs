using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExpressionTreeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manually build the expression tree for 
            // the lambda expression num => num < 5.

            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression five = Expression.Constant(5, typeof(int));

            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);

            Expression<Func<int, bool>> lambda =
                Expression.Lambda<Func<int, bool>>(
                    numLessThanFive,
                    new ParameterExpression[] { numParam });

            var func = lambda.Compile();

            // true
            bool t = func.Invoke(3);

            // false
            bool f = func.Invoke(7);

        }
    }
}
