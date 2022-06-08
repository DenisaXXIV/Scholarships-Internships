using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags.Exceptions;
using Tags.Models;

namespace Tags.Helpers
{
    public class TagValidator
    {
        public TagValidator()
        {
        }

        public void ValidateTag(Company company, string tag)
        {
            foreach (var employee in company.Employees)
            {
                if (employee.TagNumber.Equals(tag))
                {
                    Console.WriteLine("Welcome, " + employee.FirstName + employee.LastName);
                    return;
                }
            }

            if (company.BlockedAccess.FindAll(emplyee => emplyee.TagNumber == tag).Count() != 0)
            {
                throw new BlockedAccessException($"{tag} blocked !");
            }

            throw new ForbiddenAccessException($"{tag} invalid.");
        }
    }
}
