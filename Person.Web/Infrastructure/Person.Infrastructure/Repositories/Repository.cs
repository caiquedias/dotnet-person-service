using Person.Domain.Interfaces;
using Person.Infrastructure.Context;

namespace Person.Infrastructure.Repositories
{
    public class Repository : IPersonRepository
    {
        public Repository()
        {
            
        }
        public virtual Person.Domain.Aggregates.PersonAggregate.Person GetById(int id)
        {
            var person = AppMockContext.GetAll();
            return person.Where(x => x.Id == id).FirstOrDefault();
        }

        public virtual IEnumerable<Person.Domain.Aggregates.PersonAggregate.Person> GetAll()
        {
            return AppMockContext.GetAll();
        }
    }
}
