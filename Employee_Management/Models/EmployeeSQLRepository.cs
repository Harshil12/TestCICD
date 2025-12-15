
using Microsoft.EntityFrameworkCore.Internal;

namespace Employee_Management.Models
{
    public class EmployeeSQLRepository : IEmployee
    {
        public EmployeeSQLRepository(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            Context.Employees.Add(employee);
            Context.SaveChanges();
            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            Context.Remove(id);
            Context.SaveChanges(true);
            return true;
        }

        public EmployeeModel? GetEmployeeById(int id)
        {
            return Context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public IReadOnlyList<EmployeeModel> GetEmployeeList()
        {
            return Context.Employees.Take(100).ToList();
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            Context.Update(employee);
            Context.SaveChanges();
            return employee;
        }
    }
}
