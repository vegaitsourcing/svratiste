using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Entities
{
    public class LifeSkill : BaseEntity
    {
        [MaxLength(1024)]
        public Enums.LifeSkill LifeSkillType { get; set; }

        public bool IsGroupSkill { get; set; }
    }
}