using Person.Domain.Aggregates.PersonAggregate;

namespace Person.Infrastructure.Context
{
    public static class AppMockContext
    {
        public static IEnumerable<Person.Domain.Aggregates.PersonAggregate.Person> GetAll()
        {
            return new List<Person.Domain.Aggregates.PersonAggregate.Person>
            {
                new Domain.Aggregates.PersonAggregate.Person(
                    0,
                    "Eduado Vicente Pereira",
                    new DateTime(1992, 05, 13),
                    new Address(0, "Rua Mathilde de Abreu", 20, "Taboão da Serra")),

                new Domain.Aggregates.PersonAggregate.Person(
                    1,
                    "Filipe Cláudio Pereira",
                    new DateTime(1994, 02, 8),
                    new Address(1, "Rua Condor", 130, "Guarulhos")),

                new Domain.Aggregates.PersonAggregate.Person(
                    2,
                    "Maria Fátima Lima",
                    new DateTime(1993, 06, 13),
                    new Address(2, "Rua Niterói", 37, "Americana")),

                new Domain.Aggregates.PersonAggregate.Person(
                    3,
                    "Carlos Eduardo Arthur Corte Real",
                    new DateTime(1991, 05, 9),
                    new Address(3, "Rua Celso Alberti", 52, "Sorocaba")),

                new Domain.Aggregates.PersonAggregate.Person(
                    4,
                    "Esther Sueli Cardoso",
                    new DateTime(1992, 02, 22),
                    new Address(4, "Caminho 14", 824, "Rio Claro")),

             };
            
        }
    }
}
