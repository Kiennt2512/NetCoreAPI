using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }
    }
}