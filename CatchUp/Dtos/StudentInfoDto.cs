using System.Collections.Generic;
using CatchUp.Enums;

namespace CatchUp.Dtos
{
    public class StudentInfoDto
    {
        public StudentInfoDto()
        {
            Subjects = new List<Subject>();
        }
        public int UserId { get; set; }

        public List<Subject> Subjects;       
        
    }
}