using System;

namespace STA.Models
{
    public abstract class Attendee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
    }
}