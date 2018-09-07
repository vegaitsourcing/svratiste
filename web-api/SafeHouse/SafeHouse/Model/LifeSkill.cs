using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Model
{
    public class LifeSkill : BaseEntity
    {
        [MaxLength(1024)]
        public string Description { get; set; }
        public bool IsGroupSkill { get; set; }
    }
}