using System;
using System.Linq.Expressions;
using System.Reflection;

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
            

            Expression<Func<Book, object>> e = b => b.Author;

            string propertyName = GetPropertyName(e);
            
            Console.WriteLine("Property Name is {0}", propertyName);

            var bookParameter = Expression.Parameter(typeof (Book), "book");
            var memberAccess = Expression.MakeMemberAccess(bookParameter, typeof (Book).GetMember("Author")[0]);

            var handMade = Expression.Lambda<Func<Book, object>>(memberAccess, 
                                                                 new ParameterExpression[] { bookParameter });

            propertyName = GetPropertyName(handMade);

            Console.WriteLine("Property Name is {0}", propertyName);

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        

        private static string GetPropertyName(LambdaExpression lambdaExpression)
        {
            Expression e = lambdaExpression;

            while (true)
            {
                switch (e.NodeType)
                {
                    case ExpressionType.Lambda:
                        e = ((LambdaExpression)e).Body;
                        break;
                    case ExpressionType.MemberAccess:
                        var propertyInfo = ((MemberExpression)e).Member as PropertyInfo;

                        return propertyInfo != null
                                   ? propertyInfo.Name
                                   : string.Empty;
                    default:
                        return string.Empty;
                }
            }
        }
    }
}