using System.ComponentModel.DataAnnotations;

namespace StudentCoreUsingMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string subject { get; set; }
        public int Marks { get; set; } 
    }
}
