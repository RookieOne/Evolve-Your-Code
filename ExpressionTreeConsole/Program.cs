using System;
using System.Linq;
using System.Linq.Expressions;
using FizzWare.NBuilder;

namespace ExpressionTreeConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Manually build the expression tree for 
            // the lambda expression num => num < 5.

            ParameterExpression numParam = Expression.Parameter(typeof (int), "num");
            ConstantExpression five = Expression.Constant(5, typeof (int));

            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);

            Expression<Func<int, bool>> lambda =
                Expression.Lambda<Func<int, bool>>(
                    numLessThanFive,
                    new[] {numParam});

            Func<int, bool> func = lambda.Compile();

            // true
            bool t = func.Invoke(3);

            // false
            bool f = func.Invoke(7);


            var books = Builder<Book>.CreateListOfSize(50)
                .Build().AsQueryable();

            var e = from b in books
                    where b.Title == "Icarus Hunt"
                    select b;

            var expression = e.Expression;

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}