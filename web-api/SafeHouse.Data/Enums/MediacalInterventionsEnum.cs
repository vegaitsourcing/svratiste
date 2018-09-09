using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MediacalInterventionsEnum
    {
        Intervention = 1,
        Consultancy = 2,
        Medications = 4
    }
}
