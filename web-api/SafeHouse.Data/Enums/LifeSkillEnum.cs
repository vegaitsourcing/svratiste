using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum LifeSkillEnum
    {
        MakingDecisions = 1,
        ProblemSolving = 2,
        AsertiveCommunication = 4,
        HowToSayNo = 8,
        SelfAwareness = 16,
        EmotionManagment = 32,
        Empathy = 64,
        DealingWithStress = 128,
        PersonalHygiene = 256,
        ClothesHygiene = 512,
        Health = 1024,
        PesonalSafety = 2048,
        FinancialSkills = 4096,
        PersonalSpaceHygiene = 8192,
        UsingAppliances = 16384,
        Cooking = 32768,
        Manners = 65536,
        GrocerryShoping = 131072,
        PregnancyHealthCare = 262144,
        ChildCare = 524288,
        ChildEmotionalSupport = 1048576,
        ChildProtection = 2097152,
        ChildMotivation = 4194304,
        PersonalDocuments = 8388608,
        TimeManagment = 16777216,
        Trafic = 33554432,
        SpatialCoordination = 67108864,
        UsingMedia = 134217728,
        JobSearch = 268435456
    }
}
