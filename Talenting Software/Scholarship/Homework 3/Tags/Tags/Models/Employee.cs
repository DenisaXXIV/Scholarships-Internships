using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags.Interfaces;

namespace Tags.Models
{
    public class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string tagNumber;

        public Employee(string firstName, string lastName, string tagNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.tagNumber = tagNumber;
        }

        [JsonProperty("FirstName")]
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != null)
                {
                    firstName = value;
                }
            }
        }

        [JsonProperty("LastName")]
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != null)
                {
                    lastName = value;
                }
            }
        }

        [JsonProperty("TagNumber")]
        public string TagNumber
        {
            get { return tagNumber; }
            set
            {
                if (value != null)
                {
                    tagNumber = value;
                }
            }
        }

        public string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
