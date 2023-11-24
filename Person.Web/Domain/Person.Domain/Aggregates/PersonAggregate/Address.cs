namespace Person.Domain.Aggregates.PersonAggregate
{
    public class Address
    {
        public Address(int id, string street, int number, string municipality)
        {
            Id = id;
            Street = street;
            Number = number;
            Municipality = municipality;
        }
        public int Id { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? Municipality { get; set; }
    }
}
