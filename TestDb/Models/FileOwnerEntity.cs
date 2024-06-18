using System.Runtime.Serialization;

namespace TestDb.Models
{
    public enum FileOwnerEntity
    {
        [EnumMember(Value = "Teacher")]
        Teacher,
        [EnumMember(Value = "Student")]
        Student,
        [EnumMember(Value = "Course")]
        Course,
        [EnumMember(Value = "Module")]
        Module,
        [EnumMember(Value = "Activity")]
        Activity
    }
}
