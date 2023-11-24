namespace Person.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Person.Domain.Aggregates.PersonAggregate.Person GetById(int id);
        IEnumerable<Person.Domain.Aggregates.PersonAggregate.Person> GetAll();
    }
}
