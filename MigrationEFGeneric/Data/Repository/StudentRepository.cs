using DotNetEFMigration.Data.IRepository;
using DotNetEFMigration.Models;

namespace DotNetEFMigration.Data.Repository
{
    internal class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
    }
}
