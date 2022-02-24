namespace DotNetEFMigration.Models
{
    internal class Student : Person
    {
        public virtual Group Group { get; }
    }
}
