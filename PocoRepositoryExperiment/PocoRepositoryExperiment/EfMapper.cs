using AutoMapper;

namespace PocoRepositoryExperiment
{
    public class EfMapper
    {
        static EfMapper()
        {
            Mapper.CreateMap<Employee, Employees>();
            Mapper.CreateMap<Employees, Employee>();
        }

        public object GetDataObject(object entity)
        {
            if (entity is Employee)
                return Mapper.Map<Employee, Employees>(entity as Employee);

            return null;
        }

        public object GetEntity(object dataObject)
        {
            if (dataObject is Employees)
                return Mapper.Map<Employees, Employee>(dataObject as Employees);

            return null;
        }

        public string GetEntitySetName<T>()
        {
            if (typeof (T) == typeof (Employee))
                return "ExpenseTable";

            return null;
        }
    }
}