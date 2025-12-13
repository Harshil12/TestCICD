namespace Employee_Management.Models
{
    public interface IEmployee
    {
        IReadOnlyList<EmployeeModel> GetEmployeeList();

        EmployeeModel? GetEmployeeById(int id);

        EmployeeModel AddEmployee(EmployeeModel employee);

        EmployeeModel UpdateEmployee(EmployeeModel employee);

        bool DeleteEmployee(int id);
    }
}
