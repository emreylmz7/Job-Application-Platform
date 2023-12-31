using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUI.Models.Entities
{
    public class JobApplication
    {
        public int JobApplicationId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Resume { get; set; }
        public int JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; } = null!;
        public int  UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime ApplicationDate { get; set; }
        public ApplicationStatus Status { get; set; }
    }

    public enum ApplicationStatus
    {
        Değerlendiriliyor,
        Onaylandı,
        Reddedildi
    }
}