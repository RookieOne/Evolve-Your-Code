using System;
using System.Linq.Expressions;
using ExtensionMethodsTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionsTests
{
    [TestClass]
    public class Simple
    {
        [TestMethod]
        public void one_plus_one_should_equal_2()
        {
            // 1 + 1
            ConstantExpression one = Expression.Constant(1);
            ConstantExpression oneByAnotherName = Expression.Constant(1);

            BinaryExpression add = Expression.Add(one, oneByAnotherName);
            Expression<Func<int>> expression = Expression.Lambda<Func<int>>(add);

            int result = expression.Compile().Invoke();

            result.ShouldBe(2);
        }
    }
}