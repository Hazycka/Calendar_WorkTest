using System.ComponentModel.DataAnnotations;

namespace Calendar_WorkTest.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateAndTime { get; set; }
        public bool IsAllDay { get; set; }
    }
}
