using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Model
{
    public class LifeSkills : BaseEntity
    {
        [MaxLength(1024)]
        public String Description { get; set; }
        public bool IsGroupSkill { get; set; }
    }
}