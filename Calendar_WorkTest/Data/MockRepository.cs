using Calendar_WorkTest.Models;

namespace Calendar_WorkTest.Data
{
    public class MockRepository : IRepository
    {
        private List<Event> _events;

        public MockRepository()
        {
            _events = new List<Event>()
            {
                new()
                {
                    Id = 0,
                    Name = "Всякие дела",
                    DateAndTime = new(2022, 7, 26, 0, 0, 0),
                    IsAllDay = true
                },
                new()
                {
                    Id = 1,
                    Name = "VK Fest",
                    DateAndTime = new(2022, 7, 23, 10, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 2,
                    Name = "Открытие сезона",
                    DateAndTime = new(2022, 7, 12, 17, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 3,
                    Name = "MY.GAMES",
                    DateAndTime = new(2022, 7, 12, 15, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 4,
                    Name = "Онлайн трансляция",
                    DateAndTime = new(2022, 7, 11, 19, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 5,
                    Name = "Онлайн заруба",
                    DateAndTime = new(2022, 7, 19, 19, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 6,
                    Name = "Mystic-music",
                    DateAndTime = new(2022, 7, 22, 19, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 7,
                    Name = "Антон",
                    DateAndTime = new(2022, 6, 28, 16, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 8,
                    Name = "Дима",
                    DateAndTime = new(2022, 6, 28, 13, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 9,
                    Name = "Саша",
                    DateAndTime = new(2022, 6, 28, 17, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 10,
                    Name = "Отчет по проделаннной работе",
                    DateAndTime = new(2022, 7, 29, 14, 0, 0),
                    IsAllDay = false
                },
                new()
                {
                    Id = 11,
                    Name = "Парикмахерская",
                    DateAndTime = new(2022, 8, 3, 15, 30, 0),
                    IsAllDay = false
                }
            };
        }

        public Event CreateEvent(Event newEvent)
        {
            newEvent.Id = _events.Max(e => e.Id) + 1;
            _events.Add(newEvent);
            return newEvent;
        }

        public Event DeleteEvent(int id)
        {
            Event eventToDelete = _events.FirstOrDefault(e => e.Id == id);

            if (eventToDelete != null)
                _events.Remove(eventToDelete);

            return eventToDelete;
        }

        public List<Event> GetEvents()
        {
            return new List<Event>(_events);
        }

        public Event UpdateEvent(Event eventToUpdate)
        {
            Event updatedEvent = _events.FirstOrDefault(e => e.Id == eventToUpdate.Id);
            if(updatedEvent != null)
            {
                updatedEvent.Name = eventToUpdate.Name;
                updatedEvent.DateAndTime = eventToUpdate.DateAndTime;
                updatedEvent.IsAllDay = eventToUpdate.IsAllDay;
            }
            return updatedEvent;
        }
    }
}
