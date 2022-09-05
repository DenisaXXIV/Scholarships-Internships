using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Models
{
    public class Training
    {
        String Name;
        int StartDate;
        int EndDate;

        public Training(string name, int startDate, int endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
