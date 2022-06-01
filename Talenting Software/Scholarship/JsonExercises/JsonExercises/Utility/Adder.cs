using JsonExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Utility
{
    public class Adder
    {
        public static void AddMember(List<Member> members)
        {
            string name;
            int age;
            string secretIdentity;
            List<string> powers = new();
            string power;
            int nrPowers;


            Console.WriteLine("     Add New Member\n");
            Console.WriteLine("Name:");
            name = Console.ReadLine();

            Console.WriteLine("\nAge:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSecret Identity:");
            secretIdentity = Console.ReadLine();

            Console.WriteLine("\nNumber of Powers:");
            nrPowers = int.Parse(Console.ReadLine());

            for (var index = 0; index < nrPowers; index++)
            {
                Console.WriteLine("\nPower " + (index + 1) + ":");
                power = Console.ReadLine();
                powers.Add(power);
            }

            Member member = new Member(name, age, secretIdentity, powers);
            members.Add(member);
        }

        public static Squad AddSquad()
        {
            string squadName;
            string homeTown;
            int formed;
            string secretBase;
            bool active = true;
            List<Member> members = new();
            int nrMembers;


            Console.WriteLine("     Add New Squad\n");
            Console.WriteLine("Name:");
            squadName = Console.ReadLine();

            Console.WriteLine("\nHome Town:");
            homeTown = Console.ReadLine();

            Console.WriteLine("\nIs it Active? Y/N");
            var aux = Console.ReadLine();
            if (aux == "Y" || aux == "y")
            {
                active = true;
            }
            else if (aux == "N" || aux == "n")
            {
                active = false;
            }

            Console.WriteLine("\nFormed:");
            formed = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSecret Base:");
            secretBase = Console.ReadLine();

            Console.WriteLine("\nNumber of Members:");
            nrMembers = int.Parse(Console.ReadLine());

            for (var index = 0; index < nrMembers; index++)
            {
                AddMember(members);
            }

            Squad newSquad = new Squad(squadName, homeTown, formed, secretBase, active, members);

            return newSquad;
        }
    }
}
