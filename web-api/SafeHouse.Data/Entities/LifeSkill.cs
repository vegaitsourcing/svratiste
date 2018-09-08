using SafeHouse.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Data.Entities 
{
    public class LifeSkill : BaseEntity
    {
        [MaxLength(1024)]
        public LifeSkillEnum LifeSkillType { get; set; }
        public bool IsGroupSkill { get; set; }
    }
}