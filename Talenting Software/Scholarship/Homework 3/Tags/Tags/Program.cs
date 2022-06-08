using Tags.Helpers;
using Tags.Models;

namespace Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            EmployeeService employeeService = new EmployeeService();


            employeeService.ReturningEmplyee(company);
        }
    }
}