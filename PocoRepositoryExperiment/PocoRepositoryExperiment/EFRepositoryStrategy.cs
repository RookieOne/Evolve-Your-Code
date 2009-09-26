using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PocoRepositoryExperiment
{
    public class EFRepositoryStrategy
    {
        GreekFireExpenseDBEntities Database { get; set; }
        EfMapper Mapper { get; set; }

        public EFRepositoryStrategy()
        {
            Database = new GreekFireExpenseDBEntities();
            Mapper = new EfMapper();            
        }

        public IQueryable<T> GetAll<T>()
        {
            var result = new List<T>();
            foreach (var dataObject in Database.Employees)
            {
                result.Add((T)Mapper.GetEntity(dataObject));
            }

            return result.AsQueryable<T>();
        }

        public IQueryable<T> Query<T>(Expression expression)
        {
            var modifier = new DataMapModifier(Database);
            var executed = modifier.Execute(expression);

            var result = new List<T>();
            foreach (var dataObject in executed)
            {
                result.Add((T)Mapper.GetEntity(dataObject));
            }

            return result.AsQueryable<T>();
        }
    }
}
