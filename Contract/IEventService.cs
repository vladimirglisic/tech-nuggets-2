using Nugget2.Model;

namespace Nugget2.Contract
{
    public interface IEventService
    {
        IEnumerable<Event> Get();
    }
}
