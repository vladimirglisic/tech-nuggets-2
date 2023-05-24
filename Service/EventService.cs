using Nugget2.Contract;
using Nugget2.Model;

namespace Nugget2.Service
{
    public class EventService : IEventService
    {
        public IEnumerable<Event> Get()
        {
            return new[] {
                new Event { Name = "Event A", Date = new DateTime(2023, 6, 1, 20, 0, 0)},
                new Event { Name = "Event B", Date = new DateTime(2023, 6, 2, 20, 0, 0)},
                new Event { Name = "Event C", Date = new DateTime(2023, 6, 3, 20, 0, 0)},
            };
        }
    }
}
