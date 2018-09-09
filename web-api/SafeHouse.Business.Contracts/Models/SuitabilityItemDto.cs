﻿using System;

namespace SafeHouse.Business.Contracts.Models
{
    public class SuitabilityItemDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public SuitabilityCacheDto SuitabilityCache { get; set; }
    }
}
