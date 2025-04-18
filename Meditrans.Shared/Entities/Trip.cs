﻿using System.ComponentModel.DataAnnotations;

namespace Meditrans.Shared.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan FromTime { get; set; }
        public TimeSpan? ToTime { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public string PickupAddress { get; set; }
        [Required]
        public double PickupLatitude { get; set; }
        [Required]
        public double PickupLongitude { get; set; }
        [Required]
        public string DropoffAddress { get; set; }
        [Required]
        public double DropoffLatitude { get; set; }
        [Required]
        public double DropoffLongitude { get; set; }
        [Required]
        public int SpaceTypeId { get; set; }
        public SpaceType SpaceType { get; set; }
        public string? PickupNote { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
