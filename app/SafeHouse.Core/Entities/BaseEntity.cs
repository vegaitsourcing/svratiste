using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SafeHouse.Core.Abstractions.Data;

namespace SafeHouse.Core.Entities
{
    public abstract class BaseEntity : IDomainEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModificationDate { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}