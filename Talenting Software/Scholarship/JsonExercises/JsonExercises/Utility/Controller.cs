using JsonExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Utility
{
    internal class Controller
    {
        public static void StartController()
        {
            var response = Console.ReadLine();

            while (ResponseValidator.ValidateResponse(response) == false)
            {
                Console.WriteLine("Please try again\n");
                response = Console.ReadLine();
            }

            Squad squad = new Squad(FileReader.ReadSquad());

            List<Squad> squads = new List<Squad>();
            squads.Add(squad);

            string filename;

            switch (response)
            {
                case "A":
                    Console.Clear();
                    squads[0].ToString();
                    break;
                case "B":
                    Console.Clear();
                    squads[0].Members = squads[0].Members.OrderBy(m => m.Name).ToList();
                    squads[0].ToString();
                    break;
                case "C":
                    Console.Clear();
                    squads[0].Members = squads[0].Members.OrderBy(m => m.Name)
                        .ThenBy(m => m.Powers).ToList();
                    squads[0].ToString();
                    break;
                case "D":
                    Console.Clear();
                    squads[0].Members.OrderByDescending(m => m.Age).First().ToString();
                    break;
                case "E":
                    Console.Clear();
                    squads[0].Members = squads[0].Members.Where(m => m.SecretIdentity == "Unknown").ToList();
                    squads[0].ToString();
                    break;
                case "F":
                    Console.Clear();
                    Adder.AddMember(squads[0].Members);
                    Console.WriteLine("\nName of the file:");
                    filename = Console.ReadLine();
                    Utility.FileWriter.WriteSquad(squads[0], filename + ".json");
                    Console.WriteLine("\nPlease press ENTER to continue... ");
                    break;
                case "G":
                    Console.Clear();
                    squads.Add(Adder.AddSquad());
                    Console.WriteLine("\nName of the file:");
                    filename = Console.ReadLine();
                    Utility.FileWriter.WriteSquads(squads, filename + ".json");
                    Console.WriteLine("\nPlease press ENTER to continue... ");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Program.Start();
        }
    }
}
