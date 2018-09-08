using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MediationSpeakingEnum
    {
        SocialCentar = 1,
        HealthCentar = 2,
        Police = 4,
        Rest = 8
    }
}
