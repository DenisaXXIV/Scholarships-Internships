namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The company allow us to work in interval 8:00 - 18:00, with a lunch break of 45 minutes\n");
            Start();
        }

        public static void Start()
        {
            TimeOnly startProgram = GetStartingHour();

            TimeOnly program = GetHoursToWork();

            TimeSpan working = GetWorkingHours(startProgram, program);

            ValidateProgram(working);


            Console.WriteLine("You still have to work:" + working.ToString());
        }

        // Check if the employee can finish his shift 
        public static void ValidateProgram(TimeSpan working)
        {
            TimeOnly end = new(18, 00);

            TimeOnly time = Now();

            if (end.CompareTo(TimeOnly.Parse((TimeOnly.Parse(working.ToString()) - time).ToString())) < 0)
            {
                throw new InvalidProgramException();
            }
        }

        // get the hours that the employee still has to work
        public static TimeSpan GetWorkingHours(TimeOnly start, TimeOnly program)
        {
            TimeOnly time = Now();

            TimeSpan working = time - start;
            working = program - TimeOnly.Parse(working.ToString());

            return working;
        }

        // get the current time
        public static TimeOnly Now()
        {
            return new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);
        }

        // get the time the employee started their shift
        public static TimeOnly GetStartingHour()
        {
            Console.WriteLine("Starting Program Hour: ");

            string time;
            TimeOnly start = new(8, 00);


            try
            {
                time = Console.ReadLine();
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Please write when did you start the program!");
            }
            catch (InvalidProgramException ex)
            {
                throw ex;
            }

            if (start.CompareTo(TimeOnly.Parse(time)) > 0)
            {
                throw new InvalidProgramException();
            }

            return TimeOnly.Parse(time);
        }

        // get the number of hours the employee has to work in total to complete the shift
        public static TimeOnly GetHoursToWork()
        {
            Console.WriteLine("Type of Program(Full time / Part time): ");
            string type;
            try
            {
                type = Console.ReadLine();
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Please write Full time or Part time!");
            }

            if (type[0] == 'F' || type[0] == 'f')
            {
                return new TimeOnly(8, 45);
            }
            else
            {
                return new TimeOnly(4, 45);
            }

        }
    }
}
