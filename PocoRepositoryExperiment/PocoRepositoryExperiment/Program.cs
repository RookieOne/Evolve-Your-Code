using System;
using System.Collections.Generic;

namespace PocoRepositoryExperiment
{
    internal class Program
    {
        private static EmployeeRepository _repository;

        private static void Main(string[] args)
        {
            _repository = new EmployeeRepository();

            DisplayJBsBad();

            DisplayJBs();

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void DisplayJBs()
        {
            IEnumerable<Employee> employees = _repository.Good();

            foreach (Employee e in employees)
                Console.Write(e);
        }

        private static void DisplayJBsBad()
        {
            IEnumerable<Employee> employees = _repository.Bad();

            foreach (Employee e in employees)
                Console.Write(e);
        }

        private static void DisplayExpenses()
        {
            Console.WriteLine("Display Expenses");
            var repository = new EmployeeRepository();

            IEnumerable<Employee> employees = repository.GetAll();

            foreach (Employee e in employees)
                Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}