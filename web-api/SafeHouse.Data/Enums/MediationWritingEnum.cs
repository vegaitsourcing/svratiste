using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MediationWritingEnum
    {
        SocialCentar = 1,
        EdicationalCentar = 2,
        HealthCentar = 4,
        CivilCentar = 8,
        Police = 16,
        Rest = 32,
    }
}
