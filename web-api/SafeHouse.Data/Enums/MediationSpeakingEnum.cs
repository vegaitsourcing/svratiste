using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MediationSpeakingEnum
    {
        None = 0,
        SocialCentar = 1 << 0,
        HealthCentar = 1 << 1,
        Police = 1 << 2,
        Rest = 1 << 3
    }
}
