using JsonExercises.Interfaces;
using JsonExercises.Models;
using JsonExercises.Utility;
using System.Collections.ObjectModel;
using System.Linq;

namespace JsonExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("                 Super Heros Manager\n");

            Console.WriteLine(" 1. Display all data                                                [A]\n");
            Console.WriteLine(" 2. Display all members, ordered by the name                        [B]\n");
            Console.WriteLine(" 3. Display all members, ordered by the name and powers             [C]\n");
            Console.WriteLine(" 4. Display the older superhero                                     [D]\n");
            Console.WriteLine(" 5. Display the name of the hero with the secretIdentity “Unknown”  [E]\n");
            Console.WriteLine(" 6. Add a new member for the squad “Super Hero Squad”               [F]\n");
            Console.WriteLine(" 7. Add a new squad                                                 [G]\n");

            Utility.Controller.StartController();
        }
    }
}