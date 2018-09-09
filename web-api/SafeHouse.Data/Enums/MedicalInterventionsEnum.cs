using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum MedicalInterventionsEnum
    {
        None = 0,
        Intervention = 1,
        Consultancy = 2,
        Medications = 4
    }
}
