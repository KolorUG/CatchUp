using System.Collections.Generic;
using CatchUp.Enums;

namespace CatchUp.Dtos
{
    public class StudentInfoDto
    {
        public int UserId { get; set; }
        public List<Subject> Subjects;
    }
}