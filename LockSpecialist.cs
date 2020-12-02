using System;

namespace classicHeist
{
    public class LockSpecialist : IRobber
    {
        public string Specialty { get; } = "Lock Specialist";
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name}'s {SkillLevel} for removing locks the {bank.VaultScore}");
            if (bank.VaultScore - SkillLevel <= 0)
            {
                Console.WriteLine($"{Name} has disabled the locks!");
            }
        }
    }
}