using System;

namespace SafeHouse.Core.Entities.Enums
{
    [Flags]
    public enum MediationSpeaking
    {
        None = 0,
        SocialCenter = 1 << 0,
        HealthCenter = 1 << 1,
        Police = 1 << 2,
        Rest = 1 << 3
    }
}
