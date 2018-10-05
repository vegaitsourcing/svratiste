using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum LifeSkillEnum
    {
        None = 0,
        MakingDecisions = 1 << 0,
        ProblemSolving = 1 << 1,
        AsertiveCommunication = 1 << 2,
        HowToSayNo = 1 << 3,
        SelfAwareness = 1 << 4,
        EmotionManagment = 1 << 5,
        Empathy = 1 << 6,
        DealingWithStress = 1 << 7,
        PersonalHygiene = 1 << 8,
        ClothesHygiene = 1 << 9,
        Health = 1 << 10,
        PesonalSafety = 1 << 11,
        FinancialSkills = 1 << 12,
        PersonalSpaceHygiene = 1 << 13,
        UsingAppliances = 1 << 14,
        Cooking = 1 << 15,
        Manners = 1 << 16,
        GrocerryShoping = 1 << 17,
        PregnancyHealthCare = 1 << 18,
        ChildCare = 1 << 19,
        ChildEmotionalSupport = 1 << 20,
        ChildProtection = 1 << 21,
        ChildMotivation = 1 << 22,
        PersonalDocuments = 1 << 23,
        TimeManagment = 1 << 24,
        Trafic = 1 << 25,
        SpatialCoordination = 1 << 26,
        UsingMedia = 1 << 27,
        JobSearch = 1 << 28
    }
}
