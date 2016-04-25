using StudyTracker.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudyTracker.WebApi.Controllers
{
    public class TechnologyController : ApiController
    {
        private readonly Technology[] _technologies = new Technology[]
        {
            new Technology("Web-Api", ""),
            new Technology(".NET Framework", "")
        };
        
        public IEnumerable<Technology> GetAllTechnologies()
        {
            return _technologies;
        }

        public IHttpActionResult GetTechnology(int id)
        {
            var technology = _technologies.FirstOrDefault(x => x.Name == id.ToString());
            if (technology== null)
            {
                return NotFound();
            }
            return Ok(technology);
        }
    }
}
