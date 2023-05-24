using Nugget2.Contract;
using Nugget2.Model;

namespace Nugget2.Service
{
    public class EventService : IEventService
    {
        private readonly ILogger<EventService> logger;

        public EventService(ILogger<EventService> logger)
        {
            this.logger = logger;
        }

        public IEnumerable<Event> Get()
        {
            logger.LogDebug("Get method is called.");

            return new[] {
                new Event { Name = "Event A", Date = new DateTime(2023, 6, 1, 20, 0, 0)},
                new Event { Name = "Event B", Date = new DateTime(2023, 6, 2, 20, 0, 0)},
                new Event { Name = "Event C", Date = new DateTime(2023, 6, 3, 20, 0, 0)},
            };
        }
    }
}
