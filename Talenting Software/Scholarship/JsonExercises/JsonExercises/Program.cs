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
            //Console.WriteLine("                 Super Heros Manager\n");

            //Console.WriteLine(" 1. Display all data                                                [A]\n");
            //Console.WriteLine(" 2. Display all members, ordered by the name                        [B]\n");
            //Console.WriteLine(" 3. Display all members, ordered by the name and powers             [C]\n");
            //Console.WriteLine(" 4. Display the older superhero                                     [D]\n");
            //Console.WriteLine(" 5. Display the name of the hero with the secretIdentity “Unknown”  [E]\n");
            //Console.WriteLine(" 6. Add a new member for the squad “Super Hero Squad”               [F]\n");
            //Console.WriteLine(" 7. Add a new squad                                                 [G]\n");

            //Utility.Controller.StartController();

            Training tr1 = new Training("Ballet Circle", 2011, 2012);
            Training tr2 = new Training("Excellence in Chemistry", 2014, 2017);
            Training tr3 = new Training("Architecture and Urbanism Courses", 2016, 2018);
            Training tr4 = new Training("\"From Idea to Business\" Workshop", 2017, 2017);
            List<Training> trainingList1 = new List<Training>();
            List<Training> trainingList2 = new List<Training>();
            List<List<Training>> trainingList3 = new List<List<Training>>();
            trainingList1.Add(tr1);
            trainingList1.Add(tr2);
            trainingList2.Add(tr3);
            trainingList2.Add(tr4);
            trainingList3.Add(trainingList1);
            trainingList3.Add(trainingList2);


            Education ed1 = new Education(2008, 2016, "School of Arts and Crafts \"Toma Caragiu\"",
                "https://github.com/DenisaXXIV/portofolio/blob/main/Vanilla%20JS/imagini/logo%20educatie/TomaCaragiu.png",
                "English and Arts", "Romania, Prahova, Ploiesti, Street Minerva 4", "http://scoalacaragiuploiesti.ro/");

            Education ed2 = new Education(2016, 2020, "National College \"Mihai Viteazul\"",
                "https://github.com/DenisaXXIV/portofolio/blob/main/Vanilla%20JS/imagini/logo%20educatie/CNMV.png",
                "Natural Sciences, bilingual French", "Romania, Prahova, Ploiesti, Independence Boulevard 8",
                "http://cnmv.ploiesti.roedu.net");

            Education ed3 = new Education(2020, 2023, "Faculty of Psychology and Educational Sciences",
                "https://github.com/DenisaXXIV/portofolio/blob/main/Vanilla%20JS/imagini/logo%20educatie/pse.png",
                "Computer Science - DPPD", "Romania, Brasov, Brasov, Street Nicolae Bălcescu 56"
                , "https://psihoedu.unitbv.ro/ro/");

            Education ed4 = new Education(2020, 2023, "Faculty of Mathematics and Computer Science",
                "https://github.com/DenisaXXIV/portofolio/blob/main/Vanilla%20JS/imagini/logo%20educatie/fmi.png",
                "Computer Science", "Romania, Brasov, Brasov, Street Iuliu Maniu 50",
                "https://mateinfo.unitbv.ro/ro/");

            List<Education> listEd = new List<Education>();
            listEd.Add(ed1);
            listEd.Add(ed2);
            listEd.Add(ed3);
            listEd.Add(ed4);

            FileWriter fw = new FileWriter();

            fw.WriteObject<Education>(ed1, "EduData.json");

            fw.Write(listEd, "EducationData.json");
            fw.Write(trainingList2, "TrainingsData.json");
        }
    }
}