
namespace Employee_Management.Models
{
    public class MockEmployeeRepository : IEmployee
    {
        public List<EmployeeModel> _emplList { get; set; }
        public MockEmployeeRepository()
        {
            _emplList =
            [
                new() { Id = 1,Name = "Harshil"},
                new()  { Id = 2,Name =  "Aarohi"}
           ];
        }

        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            var maxID = _emplList.Max(x => x.Id);
            employee.Id = maxID + 1;
            _emplList.Add(employee);

            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _emplList.SingleOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _emplList.Remove(employee);
                return true;
            }

            return false;
        }

        public EmployeeModel? GetEmployeeById(int id)
        {
            return _emplList.SingleOrDefault(x => x.Id == id);
        }

        public IReadOnlyList<EmployeeModel> GetEmployeeList()
        {
            return _emplList;
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            var employeeTobeUpdated = _emplList.SingleOrDefault(x => x.Id == employee.Id);
            if(employee != null)
            {
                employeeTobeUpdated.Name = employee.Name;
            }
            else
            {
                return AddEmployee(employee);  
            }
            return employeeTobeUpdated;
        }
    }
}
