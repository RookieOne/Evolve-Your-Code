using System;
using System.Linq.Expressions;
using Expressions;
using ExtensionMethodsTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionsTests
{
    [TestClass]
    public class ExpressionHelperTests
    {
        [TestMethod]
        public void get_property_name()
        {
            Expression<Func<Book, object>> e = b => b.Author;

            var propertyName = ExpressionHelper.GetPropertyName(e);

            propertyName.ShouldBe("Author");
        }

        [TestMethod]
        public void get_property_name_building_expression_by_hand()
        {
            var bookParameter = Expression.Parameter(typeof(Book), "book");
            var memberAccess = Expression.MakeMemberAccess(bookParameter, typeof(Book).GetMember("Author")[0]);

            var handMade = Expression.Lambda<Func<Book, object>>(memberAccess,
                                                                 new ParameterExpression[] { bookParameter });

            var propertyName = ExpressionHelper.GetPropertyName(handMade);

            propertyName.ShouldBe("Author");
        }
    }
}