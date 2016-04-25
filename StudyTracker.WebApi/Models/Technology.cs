using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyTracker.WebApi.Models
{
    public class Technology
    {
        public Technology() { }
        public Technology(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}