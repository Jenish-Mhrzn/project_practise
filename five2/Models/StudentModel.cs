using System.ComponentModel.DataAnnotations;

namespace lab5Q2.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Student Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Semester is required")]
        [Range(1, 12, ErrorMessage = "Semester must be between 1 and 12")]
        public int Semester { get; set; }
    }
}
