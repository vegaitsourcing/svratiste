using System;
using System.Collections.Generic;

namespace SafeHouse.Core.Models
{
    public class SuitabilityDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public IEnumerable<SuitabilityItemDto> SuitabilityItems { get; set; }
    }
}
