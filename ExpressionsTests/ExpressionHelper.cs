using System.Linq.Expressions;
using System.Reflection;

namespace Expressions
{
    public static class ExpressionHelper
    {
        public static string GetPropertyName(LambdaExpression lambdaExpression)
        {
            Expression e = lambdaExpression.Body;
            var propertyInfo = ((MemberExpression) e).Member as PropertyInfo;

            return propertyInfo != null
                       ? propertyInfo.Name
                       : string.Empty;
        }
    }
}