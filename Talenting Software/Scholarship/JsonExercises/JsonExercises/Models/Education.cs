using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Models
{
    public class Education
    {
        int StartDate;
        int EndDate;
        string Name;
        string Logo;
        string Specialization;
        string Address;
        string Site;

        public Education(int startDate, int endDate, string name, string logo, string specialization, string address, string site)
        {
            StartDate = startDate;
            EndDate = endDate;
            Name = name;
            Logo = logo;
            Specialization = specialization;
            Address = address;
            Site = site;
        }
    }
}
