using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using TestDb.Models;

namespace TestDb.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "A first name is required (up to 15 charaters")]
        public string StudentFirstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "A last name is required (up to 15 charaters")]
        public string StudentLastName { get; set; }
        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        [NotMapped]
        public ICollection<Document> OwnedDocuments { get; set; }
    }

    public class Teacher
    {
        public Guid TeacherId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "First name is required (up to 15 characters)")]
        public string TeacherFirstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Last name is required (up to 15 characters)")]
        public string TeacherLastName { get; set; }
        [Required]
        [EmailAddress]
        public string TeacherEmail { get; set; }
        [NotMapped]
        public ICollection<Document> OwnedDocuments { get; set; }
    }
    public class Course
    {
        public Guid CourseId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Course name is required (up to 15 characters)")]
        public string CourseName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Course description is required (up to 50 characters)")]
        public string CourseDescription { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Starting date")]
        public DateTime CourseStartDate { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Student> Students { get; set; }
        [NotMapped]
        public ICollection<Document> OwnedDocuments { get; set; }
    }

    public class Module
    {
        public Guid ModuleId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Module name is required (up to 15 characters)")]
        public string ModuleName { get; set; }
        public string? ModuleDescription { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Starting date")]
        public DateTime ModuleStartDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ending date")]
        public DateTime? ModuleEndDate { get; set; }
        public ICollection<Activity> Activities { get; set; }
        [NotMapped]
        public ICollection<Document> OwnedDocuments { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }

    public class Activity
    {
        public Guid ActivityId { get; set; }
        [Required]
        public string ActivityType { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Activity name is required (up to 15 characters)")]
        public string ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Starting date")]
        public DateTime ActivityStartDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ending date")]
        public DateTime? ActivityEndDate { get; set; }
        [NotMapped]
        public ICollection<Document> OwnedDocuments { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
    }

    public class Document
    {
        public Guid DocumentId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Document name is required (up to 15 characters)")]
        public string DocumentName { get; set; }
        public string? DocumentDescription { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Uploaded")]
        public DateTime DocumentTimeStamp { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] DocumentByte { get; set; }
        [Required]
        public Guid OwnerGuid { get; set; }

        [Required]
        public FileOwnerEntity FileOwnerEntity { get; set; }

    }
}


