using DotNetEFMigration.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetEFMigration.Data
{
    internal class AppDbContext : DbContext
    {
        DbSet<Group> Groups { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=EducationCenter;Trusted_Connection=True;");
        }
    }
}
