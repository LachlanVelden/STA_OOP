using System;
using System.Collections.Generic;

namespace STA.Models
{
    public class Session
    {
        public Guid Id { get; set; }
        public string room;
        public DateTime time;
        public Teacher teacher;
        public List<AttendanceModel> Attendance { get; set; }
    }
}
