using System;

namespace SearchBuilder.Example
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public Colors FavoriteColor { get; set; }
    }

    public class PersonSearchBuilder : SearchBuilder<Person>
    {

    }
}
