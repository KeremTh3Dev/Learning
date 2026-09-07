using System;

namespace Learning.Homeworks
{
    public class SecurityProfile
    {
        const byte MaxRiskLimit = 255;
        
        public bool CheckAcces(int age, bool hasCard, bool isBanned)
        {
            return age >= 18 && hasCard && !isBanned; 
        }
        public byte CalculateRiskLevel(float dailyUsage, int penaltyPoints)
        {
            return (byte)((dailyUsage * 10) + penaltyPoints);
        }
    }
}
