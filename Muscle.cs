using System;

namespace classicHeist
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is removing the guards. Decreased Guards by {SkillLevel} points");
            if (bank.SecurityGuardScore - SkillLevel <= 0)
            {
                Console.WriteLine($"{Name} has disabled the Guards!");
            }
        }
    }
}