namespace Person.Domain.Aggregates.PersonAggregate
{
    public class Person
    {
        public Person(int id, string name, DateTime bithDate, Address address)
        {
            Id = id;
            Name = name;
            BirthDate = bithDate;   
            Address = address;
        }

        public int Id { get; private set; }
        public string? Name{ get; private set; }
        public DateTime BirthDate { get; private set; }
        public Address? Address { get; private set; }
    }
}
