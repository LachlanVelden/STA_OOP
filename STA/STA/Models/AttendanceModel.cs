using System;

namespace STA.Models
{
    public class AttendanceModel
    {
        public Guid Id { get; set; }
        public DateTime timeArrived;
        public Student student;
        public DateTime timeLeft;
    }
}