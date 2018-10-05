using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MedicalInterventionsEnum
    {
        None = 0,
        Intervention = 1 << 0,
        Consultancy = 1 << 1,
        Medications = 1 << 2
    }
}
