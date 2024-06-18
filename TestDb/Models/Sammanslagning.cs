using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

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
        public ICollection<Document> OwnedDocuments { get; set; }
    }

    public class Teacher
    {
        public Guid TeacherId { get; set; }
        [Required]
        [StringLength(15)]
        public string TeacherFirstName { get; set; }
        [Required]
        [StringLength(15)]
        public string TeacherLastName { get; set; }
        [Required]
        [EmailAddress]
        public string TeacherEmail { get; set; }
        public ICollection<Document> OwnedDocuments { get; set; }
    }
    public class Course
    {
        public Guid CourseId { get; set; }
        [Required]
        [StringLength(15)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(50)]
        public string CourseDescription { get; set; }
        [Required]
        public DateTime CourseStartDate { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Document> OwnedDocuments { get; set; }
    }

    public class Module
    {
        public Guid ModuleId { get; set; }
        [Required]
        [StringLength(15)]
        public string ModuleName { get; set; }
        public string? ModuleDescription { get; set; }
        [Required]
        public DateTime ModuleStartDate { get; set; }
        public DateTime? ModuleEndDate { get; set; }
        public ICollection<Activity> Activities { get; set; }
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
        [StringLength(15)]
        public string ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        [Required]
        public DateTime ActivityStartDate { get; set; }
        public DateTime? ActivityEndDate { get; set; }
        public ICollection<Document> OwnedDocuments { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
    }

    public class Document
    {
        public Guid DocumentId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "File name is required (up to 15 characters)")]
        public string DocumentName { get; set; }
        public string? DocumentDescription { get; set; }
        [Required]
        public DateTime DocumentTimeStamp { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] DocumentByte { get; set; }
        [Required]
        public Guid OwnerGuid { get; set; }
        [Required]
        public FileOwnerEntity OwnerEntity { get; set; }

        public string GetJsonRepresentation()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(this, settings);
        }
        public static Document FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Document>(json);
        }
    }
}



// guid, content, ownertype, guid ägare - guid/content/<entities>(guid)
// skapa ind. guid vid varje ny entitet