using System;
using System.Collections.Generic;

namespace classicHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IRobber> rolodex = new List<IRobber>();
            IRobber JeffTheHacker = new Hacker()
            {
                Name = "Jeff",
                SkillLevel = 25,
                PercentageCut = 10
            };
            IRobber SuzyTheHacker = new Hacker()
            {
                Name = "Suzy",
                SkillLevel = 35,
                PercentageCut = 15
            };
            IRobber PunchyMcGee = new Muscle()
            {
                Name = "Harold 'Punchy' McGee",
                SkillLevel = 75,
                PercentageCut = 25
            };
            IRobber SteveKnuckles = new Muscle()
            {
                Name = "Steve the Knuckles",
                SkillLevel = 20,
                PercentageCut = 5
            };
            IRobber JaneThePicker = new LockSpecialist()
            {
                Name = "Jane",
                SkillLevel = 45,
                PercentageCut = 25
            };
            IRobber George = new LockSpecialist()
            {
                Name = "George",
                SkillLevel = 7,
                PercentageCut = 50
            };
            rolodex.Add(JeffTheHacker);
            rolodex.Add(SuzyTheHacker);
            rolodex.Add(PunchyMcGee);
            rolodex.Add(SteveKnuckles);
            rolodex.Add(JaneThePicker);
            rolodex.Add(George);
            Console.WriteLine("Available Robbers");
            rolodex.ForEach(robber =>
            {
                Console.WriteLine($"{robber.Name} - Skill Level:{robber.SkillLevel} - Cut: {robber.PercentageCut}%");

            });
            while (true)
            {

                Console.WriteLine("Have any new potential contacts? (y/n)");
                string YNResponse = Console.ReadLine();
                // add more logic for answers other than 'n'
                if (YNResponse == "n")
                {
                    break;
                }
                Console.WriteLine("Enter a Name");
                string newName = Console.ReadLine();

                Console.WriteLine("What is their specialty?");
                Console.WriteLine("Hacker (Disables alarms)");
                Console.WriteLine("Muscle (Disarms guards)");
                Console.WriteLine("Lock Specialist (Cracks vault)");
                string newSpecialty;
                while (true)
                {
                    string response = Console.ReadLine();
                    if (response == "Hacker" || response == "Muscle" || response == "Lock Specialist")
                    {
                        newSpecialty = response;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("enter a specialty listed above");
                    }
                }
                //could create a try/catch to check for int
                Console.WriteLine("What is their Skill Level (1-100)");
                int skillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("What percentage cut do they want?");
                int Cut = int.Parse(Console.ReadLine());

                if (newSpecialty == "Hacker")
                {
                    Hacker NewHacker = new Hacker();

                    NewHacker.Name = newName;
                    NewHacker.SkillLevel = skillLevel;
                    NewHacker.PercentageCut = Cut;
                    rolodex.Add(NewHacker);

                }
                if (newSpecialty == "Muscle")
                {
                    Muscle NewMuscle = new Muscle();

                    NewMuscle.Name = newName;
                    NewMuscle.SkillLevel = skillLevel;
                    NewMuscle.PercentageCut = Cut;
                    rolodex.Add(NewMuscle);
                }
                if (newSpecialty == "Lock Specialist")
                {
                    LockSpecialist NewLockSpecialist = new LockSpecialist();

                    NewLockSpecialist.Name = newName;
                    NewLockSpecialist.SkillLevel = skillLevel;
                    NewLockSpecialist.PercentageCut = Cut;
                    rolodex.Add(NewLockSpecialist);
                }
            }

            rolodex.ForEach(robber =>
            {
                Console.WriteLine($"{robber.Name} - Skill Level:{robber.SkillLevel} - Cut: {robber.PercentageCut}%");

            });

        }
    }
}
