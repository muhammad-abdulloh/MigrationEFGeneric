using DotNetEFMigration.Enums;
using System;

namespace DotNetEFMigration.Models
{
    internal class Employee : Person
    {
        public int Experience { get; set; }
        public DateTime StartedDate { get; set; }
        public string CardNumber { get; set; }
        public Department Department { get; set; }
    }
}
