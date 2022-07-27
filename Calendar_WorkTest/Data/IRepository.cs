using Calendar_WorkTest.Models;

namespace Calendar_WorkTest.Data
{
    public interface IRepository
    {
        List<Event> GetEvents();
        Event CreateEvent(Event newEvent);
        Event UpdateEvent(Event eventToUpdate);
        Event DeleteEvent(int id);
    }
}
