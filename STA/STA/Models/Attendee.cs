using System;

namespace STA.Models
{
    public abstract class Attendee
    {
        public string Name;
        public string Email;
        public Guid Id { get; set; }
    }
}