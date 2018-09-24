using System.Collections.Generic;

namespace STA.Models
{
    public class Course
    {
        public string name;
        public string code;
        public List<Unit> units;
        public List<Teacher> teachers;
    }
}
