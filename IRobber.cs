namespace classicHeist
{
    public interface IRobber
    {
        string Name();
        int SkillLevel();
        int PercentageCut();
        void PerformSkill(Bank bank);

    }
}