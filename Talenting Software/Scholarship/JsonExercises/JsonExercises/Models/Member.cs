using JsonExercises.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Models
{
    public class Member : IMember
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("age")]
        public int Age;

        [JsonProperty("secretIdentity")]
        public string SecretIdentity;

        [JsonProperty("powers")]
        public List<string> Powers;

        public Member()
        {
            Powers = new List<string>();
        }

        public Member(string name, int age, string secretIdentity, List<string> powers)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Age = age;
            this.SecretIdentity = secretIdentity ?? throw new ArgumentNullException(nameof(secretIdentity));
            this.Powers = powers ?? throw new ArgumentNullException(nameof(powers));
        }

        public void ToString()
        {
            Console.WriteLine("                      " + Name);
            Console.WriteLine("\n       Age               : " + Age);
            Console.WriteLine("\n       Secret Identity   : " + SecretIdentity);
            Console.WriteLine("\n       Powers            : ");

            foreach (var power in Powers)
            {
                Console.WriteLine("\n                       -> " + power);
            }

            Console.WriteLine("\n\n");
        }

        public void ToStringNamePowers()
        {
            Console.WriteLine("                      " + Name);
            Console.WriteLine("\n       Powers            : ");

            foreach (var power in Powers)
            {
                Console.WriteLine("\n                       -> " + power);
            }

            Console.WriteLine("\n\n");
        }
    }
}
