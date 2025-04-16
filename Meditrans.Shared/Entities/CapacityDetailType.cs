﻿using System.ComponentModel.DataAnnotations;

namespace Meditrans.Shared.Entities
{
    public class CapacityDetailType

    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
