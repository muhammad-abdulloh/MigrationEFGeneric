using DotNetEFMigration.Data.IRepository;
using DotNetEFMigration.Models;

namespace DotNetEFMigration.Data.Repository
{
    internal class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
    }
}
