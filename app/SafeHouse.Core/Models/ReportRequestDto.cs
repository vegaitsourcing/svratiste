using System;
using System.ComponentModel.DataAnnotations;

namespace SafeHouse.Core.Models
{
    public class ReportRequestDto
    {
        [Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime To { get; set; }

        public NameDto ChildName { get; set; }

    }
}
