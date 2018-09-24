using System;

namespace STA.Models
{
    public class AttendanceModel
    {
        public Guid Id { get; set; }
        public DateTime TimeArrived { get; set; }
        public Student Student { get; set; }
        public DateTime TimeLeft { get; set; }
    }
}