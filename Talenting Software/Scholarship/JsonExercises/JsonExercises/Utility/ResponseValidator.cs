using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JsonExercises.Utility
{
    public class ResponseValidator
    {
        public static bool ValidateResponse(string response)
        {
            string regexString = "[A-G]";
            Regex regex = new Regex(regexString);

            Match match = regex.Match(response);

            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}
