using System;
using System.Collections.Generic;

namespace STA.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Unit> Units { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
