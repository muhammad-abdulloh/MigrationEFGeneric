using DotNetEFMigration.Data.IRepository;
using DotNetEFMigration.Data.Repository;
using DotNetEFMigration.Enums;
using DotNetEFMigration.Models;
using System;

namespace MigrationEFGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacherRepository teacherRepository = new TeacherRepository();

            Teacher teacher = new Teacher()
            {
                FirstName = "Muhammad Abdulloh",
                LastName = "Komilov",
                BirthDate = DateTime.Now,
                CardNumber = "8600 4589 5158 5488",
                Department = Department.Head,
                StartedDate = DateTime.Now,
                Experience = 25,
                Gender = Gender.Male,
                Subject = Subject.Dotnet,
                PhoneNumber = "+998 94 105 25 55"
            };

            var res = teacherRepository.CreateAsync(teacher);
            Console.WriteLine(res.Result.FirstName);
        }
    }
}
