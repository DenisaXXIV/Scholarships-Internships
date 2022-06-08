using Tags_Events_Delegates_.Helpers;
using Tags_Events_Delegates_.Models;

namespace Tags_Events_Delegates_
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();
            TagValidator tagValidator = new TagValidator();


            employeeService.EmployeeServiceEvent += tagValidator.ReturningEmplyee;
            employeeService.AnEmployeeService();

        }
    }
}