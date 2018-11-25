using System.Collections.Generic;
using CatchUp.Enums;

namespace CatchUp.Entities
{
    public class TeacherInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public int PerHour { get; set; }
        public string Currency { get; set; }
        public bool AtStudentPlace {get; set;}
        public bool AtTeacherPlace { get; set; }
        public int MaxDistance { get; set; }
        public string PhotoUrl { get; set; }
        public string Bio { get; set; }

    }
}