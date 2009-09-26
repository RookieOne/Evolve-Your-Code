using System.Collections.Generic;
using System.Linq;

namespace PocoRepositoryExperiment
{
    public class EmployeeRepository
    {
        private readonly EFRepositoryStrategy _strategy;

        public EmployeeRepository()
        {
            _strategy = new EFRepositoryStrategy();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _strategy.GetAll<Employee>().ToList();
        }

        public IEnumerable<Employee> Bad()
        {
            var result = from e in _strategy.GetAll<Employee>()
                         where e.LastName == "Fuller"
                         select e;

            return result.ToList();
        }

        public IEnumerable<Employee> Good()
        {
            var result = from e in _strategy.GetAll<Employee>()
                         where e.LastName == "Fuller"
                         select e;

            return _strategy.Query<Employee>(result.Expression).ToList();
        }
    }
}