using DotNetEFMigration.Enums;
using System.Collections.Generic;

namespace DotNetEFMigration.Models
{
    internal class Teacher : Employee
    {
        public Subject Subject { get; set; }
        public virtual ICollection<Group> Groups { get; }
        public Teacher()
        {
            Groups = new List<Group>();
        }
    }
}
