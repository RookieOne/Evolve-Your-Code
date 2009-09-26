using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PocoRepositoryExperiment
{
    public class DataMapModifier : ExpressionVisitor
    {
        private GreekFireExpenseDBEntities _database;

        public DataMapModifier(GreekFireExpenseDBEntities database)
        {
            _database = database;
        }

        public IQueryable Execute(Expression expression)
        {
            _parameterCache = new Dictionary<Type, ParameterExpression>();
            Console.WriteLine(expression);
            
            var exp = Visit(expression);

            Console.WriteLine(exp);
            //Console.ReadLine();

            Expression<Func<IQueryable>> final = Expression.Lambda<Func<IQueryable>>(exp);
            var d = final.Compile();
            return d();
        }

        protected override MemberBinding VisitBinding(MemberBinding binding)
        {
            return base.VisitBinding(binding);
        }

        protected override Expression VisitMemberInit(MemberInitExpression init)
        {
            return base.VisitMemberInit(init);
        }

        private Dictionary<Type, ParameterExpression> _parameterCache;

        protected override Expression VisitParameter(ParameterExpression p)
        {

            if (p.Type == typeof(Employee))
            {
                return GetParameterExpression(p);
            }

            return base.VisitParameter(p);
        }

        protected override IEnumerable<MemberBinding> VisitBindingList(System.Collections.ObjectModel.ReadOnlyCollection<MemberBinding> original)
        {
            return base.VisitBindingList(original);
        }

        protected override Expression VisitListInit(ListInitExpression init)
        {
            return base.VisitListInit(init);
        }

        protected override ElementInit VisitElementInitializer(ElementInit initializer)
        {
            return base.VisitElementInitializer(initializer);
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            return base.VisitUnary(u);
        }
        

        protected override Expression VisitLambda(LambdaExpression lambda)
        {
            List<ParameterExpression> ps = new List<ParameterExpression>();
            foreach(var p in lambda.Parameters)
            {
                var pExp = GetParameterExpression(p);
                ps.Add(pExp);
            }

            var final = Expression.Lambda(lambda.Body, ps.ToArray());

            return base.VisitLambda(final);
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            if (m.Type == typeof(IQueryable<Employee>))
            {
                List<Expression> arguments = new List<Expression>();

                foreach(var argument in m.Arguments)
                {
                    if (argument.NodeType == ExpressionType.Constant)
                    {
                        var arg = Expression.Constant(_database.Employees, typeof(ObjectQuery<Employees>));
                        arguments.Add(Visit(arg));
                    }
                    else
                    {
                        arguments.Add(Visit(argument));
                    }
                }

                //return Expression.Call(m.Method, arguments.ToArray());

                var typeArgs = new Type[] { typeof(Employees) };

                return Expression.Call(typeof(Queryable), "Where", typeArgs, arguments.ToArray());
            }
            
            return base.VisitMethodCall(m);
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            if (c.Value != null)
            {
                var queryable = c.Value as IQueryable<Employee>;

                if (queryable != null)
                {
                    return Expression.Constant(_database.Employees, typeof(Employees));
                }
            }

            return base.VisitConstant(c);
        }

        protected override Expression VisitMemberAccess(MemberExpression m)
        {
            if (m.Expression.Type == typeof(Employee))
            {
                var pExp = (ParameterExpression) m.Expression;
                var exp = GetParameterExpression(pExp);
                var methodInfo = (typeof(Employees)).GetProperty("LastName");                

                return Expression.MakeMemberAccess(exp, methodInfo);
            }

            return base.VisitMemberAccess(m);
        }

        private ParameterExpression GetParameterExpression(ParameterExpression expression)
        {
            if (expression.Type == typeof(Employee))
            {
                if (_parameterCache.ContainsKey(expression.Type))
                {
                    return _parameterCache[expression.Type];
                }
                else
                {
                    var paramExp = Expression.Parameter(typeof(Employees), expression.Name);
                    _parameterCache.Add(expression.Type, paramExp);

                    return paramExp;
                }
            }

            return expression;
        }



        protected override MemberAssignment VisitMemberAssignment(MemberAssignment assignment)
        {            
            return base.VisitMemberAssignment(assignment);
        }
    }
}
