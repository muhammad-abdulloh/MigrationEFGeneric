using DotNetEFMigration.Enums;
using System;

namespace DotNetEFMigration.Models
{
    internal abstract class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
