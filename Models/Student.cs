using System.ComponentModel.DataAnnotations;

namespace MyFirstApplication.Models
{
    public class Student
    {
        [Key]

        public int Id { get; set; }

        [Required, MaxLength(25)]

        public string LastName { get; set; } = "";

        [Required, MaxLength(25)]

        public string? FirstName { get; set; }

        public string? Course { get; set; } 

        public string? Email { get; set; }

        [Display(Name = "Date Created")]

        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
