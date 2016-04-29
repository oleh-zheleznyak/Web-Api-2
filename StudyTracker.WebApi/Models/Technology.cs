using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyTracker.WebApi.Models
{
    public class Technology
    {
        public Technology() { }
        public Technology(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}