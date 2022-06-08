using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags_Events_Delegates_.Exceptions;
using Tags_Events_Delegates_.Models;

namespace Tags_Events_Delegates_.Helpers
{
    public class TagValidator
    {
        public TagValidator()
        {

        }

        public void ReturningEmplyee(object source, EventArgs e)
        {
            FileHelper fileHelper = new FileHelper();
            Company company = fileHelper.ReadFile();
            string tag;

            Console.WriteLine("Introduce tag: ");

            try
            {
                tag = Console.ReadLine();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
                return;
            }

            ValidateTag(company, tag);
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
