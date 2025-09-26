using System.ComponentModel.DataAnnotations;

namespace MyFirstApplication.Models
{
    public class ActivityReservation
    {
        public int Id { get; set; }

        [Required]
        public string? OrganizationName { get; set; }

        [Required]
        public string? ActivityTitle { get; set; }

        [Required]
        public string? Venue { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateNeeded { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime TimeFrom { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime TimeTo { get; set; }

        public string? Participants { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string? Speaker { get; set; }
        public string? PurposeObjective { get; set; }
        public string? EquipmentNeeded { get; set; }
        public string? NatureOfActivity { get; set; }
        public string? SourceOfFunds { get; set; }
    }
}
