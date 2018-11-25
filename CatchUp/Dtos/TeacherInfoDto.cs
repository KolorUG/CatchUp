using System.Collections.Generic;
using CatchUp.Enums;

namespace CatchUp.Dtos
{
    public class TeacherInfoDto
    {
        public TeacherInfoDto()
        {
            Subjects = new List<Subject>();
        }
        public int UserId { get; set; }
        public List<Subject> Subjects;
        public int PerHour {get; set;}
        public string Currency {get; set;}
        public bool AtStudentPlace {get; set;}
        public bool AtTeacherPlace { get; set; }
        public int MaxDistance { get; set; }
        public string PhotoUrl { get; set; }
        public string Bio { get; set; }

    }
}