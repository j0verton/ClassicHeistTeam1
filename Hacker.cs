using System;

namespace classicHeist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points");
            if (bank.AlarmScore - SkillLevel <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}