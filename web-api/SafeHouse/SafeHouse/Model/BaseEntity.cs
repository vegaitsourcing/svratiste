using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHouse
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        Guid Id { get; set; }

        [Timestamp]
        byte[] Version { get; set; }
    }
}
