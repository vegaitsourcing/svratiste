using System;

namespace SafeHouse.Core.Entities.Enums
{
    [Flags]
    public enum MedicalInterventions
    {
        None = 0,
        Intervention = 1 << 0,
        Consultancy = 1 << 1,
        Medications = 1 << 2
    }
}
