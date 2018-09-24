using System;
using System.Collections.Generic;

namespace STA.Models
{
    public class Unit
    {
        public Guid Id { get; set; }
        public string name;
        public List<Class> Classes { get;set;}
        public List<Teacher> Teachers { get;set;}
    }
}