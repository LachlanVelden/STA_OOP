using System;
using System.Collections.Generic;

namespace STA.Models
{
    public class Class
    {
        public Guid Id { get; set; }
        public string Name;
        public List<Session> Sessions { get;set;}
        public List<Teacher> Teachers { get;set;}
    }
}