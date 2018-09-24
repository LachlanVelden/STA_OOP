using System;
using System.Collections.Generic;

namespace STA.Models
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Room { get; set; }
        public DateTime Time { get; set; }
        public Teacher Teacher { get; set; }
        public List<AttendanceModel> Attendance { get; set; }
    }
}
