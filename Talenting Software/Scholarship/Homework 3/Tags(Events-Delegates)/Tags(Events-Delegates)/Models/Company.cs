using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags_Events_Delegates_.Interfaces;

namespace Tags_Events_Delegates_.Models
{
    public class Company : ICompany
    {
        private List<Employee> employees = new List<Employee>();

        private List<Employee> blockedAccess = new List<Employee>();

        public Company(List<Employee> employees, List<Employee> blockedAccess)
        {
            this.employees = employees;
            this.blockedAccess = blockedAccess;
        }

        public Company()
        {
            this.employees = new List<Employee>();
            employees.Add(new Employee("Jonathan", "McNally", "W8783"));
            employees.Add(new Employee("Geoffrey", "Knightley", "Z34Q4"));
            employees.Add(new Employee("Keira", "Swann", "WE456"));
            employees.Add(new Employee("Elizabeth", "Crook", "P7JJ56"));

            this.blockedAccess = new List<Employee>();
            blockedAccess.Add(new Employee("Mathew", "Smith", "A2345"));
            blockedAccess.Add(new Employee("Lillo", "Rush", "J23A3"));
            blockedAccess.Add(new Employee("Jackie", "Davenport", "B2C45"));

        }

        [JsonProperty("EmployeesList")]
        public List<Employee> Employees
        {
            get { return employees; }
            set
            {
                if (value != null)
                {
                    employees = value;
                }
            }
        }

        [JsonProperty("BlockedList")]
        public List<Employee> BlockedAccess
        {
            get { return blockedAccess; }
            set
            {
                if (value != null)
                {
                    blockedAccess = value;
                }
            }
        }

        public string ToString()
        {
            StringBuilder emplyeesString = new StringBuilder();
            foreach (var employee in employees)
            {
                emplyeesString.Append(employee.ToString() + '\n');
            }

            return emplyeesString.ToString();
        }
    }
}
