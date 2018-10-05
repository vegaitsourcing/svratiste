using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MediationWritingEnum
    {
        None = 0,
        SocialCentar = 1 << 0,
        EdicationalCentar = 1 << 1,
        HealthCentar = 1 << 2,
        CivilCentar = 1 << 3,
        Police = 1 << 4,
        Rest = 1 << 5,
    }
}
