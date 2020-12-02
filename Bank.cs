using System;

namespace classicHeist
{
    public class Bank
    {
        public int CashOnHand;
        public int AlarmScore;
        public int VaultScore;
        public int SecurityGuardScore;
        public bool IsSecure()
        {
            if (AlarmScore + VaultScore + SecurityGuardScore >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}