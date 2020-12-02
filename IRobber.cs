using System;
namespace classicHeist
{
    public interface IRobber
    {
        string Specialty { get; }
        string Name { get; }
        int SkillLevel { get; }
        int PercentageCut { get; }
        void PerformSkill(Bank bank);
    }
}