using JsonExercises.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Models
{
    public class Squad : ISquad
    {
        [JsonProperty("squadName")]
        public string SquadName;

        [JsonProperty("homeTown")]
        public string HomeTown;

        [JsonProperty("formed")]
        public int Formed;

        [JsonProperty("secretBase")]
        public string SecretBase;

        [JsonProperty("active")]
        public bool Active;

        [JsonProperty("members")]
        public List<Member> Members;

        public Squad()
        {

        }

        public Squad(Squad squad)
        {
            SquadName = squad.SquadName;
            HomeTown = squad.HomeTown;
            Formed = squad.Formed;
            SecretBase = squad.SecretBase;
            Active = squad.Active;
            Members = squad.Members;
        }

        public Squad(string squadName, string homeTown, int formed, string secretBase, bool active, List<Member> members)
        {
            this.SquadName = squadName ?? throw new ArgumentNullException(nameof(squadName));
            this.HomeTown = homeTown ?? throw new ArgumentNullException(nameof(homeTown));
            this.Formed = formed;
            this.SecretBase = secretBase ?? throw new ArgumentNullException(nameof(secretBase));
            this.Active = active;
            this.Members = members ?? throw new ArgumentNullException(nameof(members));
        }

        public void ToString()
        {
            Console.WriteLine("        " + SquadName);
            Console.WriteLine("\nHome Town   : " + HomeTown);
            Console.WriteLine("\nFormed      : " + Formed);
            Console.WriteLine("\nSecret Base : " + SecretBase);
            Console.WriteLine("\nActive      : " + Active.ToString());
            Console.WriteLine("\nMembers     : ");

            foreach (var member in Members)
            {
                member.ToString();
            }
        }
    }
}
