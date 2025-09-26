using System.ComponentModel.DataAnnotations;

namespace MyFirstApplication.Models
{
    public class LockerRequest
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? IdNumber { get; set; }

        [Required]
        public string? LockerNumber { get; set; }

        public string? Semester { get; set; }

        [Phone]
        public string? ContactNumber { get; set; }

        public string? AttachedStudyLoad { get; set; }
    }
}
