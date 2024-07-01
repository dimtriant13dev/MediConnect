using System.ComponentModel.DataAnnotations;

namespace MediConnect.Api.Models.Domain.Clinic
{
    public class Clinics
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
