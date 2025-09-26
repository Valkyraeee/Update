using System.ComponentModel.DataAnnotations;

namespace MyFirstApplication.Models
{
    public class GatePass
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ApplicantType { get; set; }
        public string? Department { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string? VehicleType { get; set; }
        public string? CourseAndYear { get; set; }
        public string? VehicleColor { get; set; }

        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationValidUntil { get; set; }
    }
}