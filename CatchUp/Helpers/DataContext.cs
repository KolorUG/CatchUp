using Microsoft.EntityFrameworkCore;
using CatchUp.Entities;
 
namespace CatchUp.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
 
        public DbSet<User> Users { get; set; }
        public DbSet<TeacherInfo> TeachersInfo {get; set;}
    }
}