using CM.UI.MVC.WebAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CM.UI.MVC.WebAPI.Controllers
{
    public class CourseController : ApiController
    {
        private static List<Models.Course> repo;

        static CourseController()
        {
            repo = new List<Course>();
            repo.Add(new Course()
            {
                CourseId = 1,
                Name = ".NET"
            ,
                MaxParticipants = 10,
                Price = 250.94
            });
            repo.Add(new Course()
            {
                CourseId = 2,
                Name = "Java"
            ,
                MaxParticipants = 15,
                Price = 359.11
            });
        }
        public IHttpActionResult Get()
        {
            if (repo.Count == 0)
            {
                return StatusCode(System.Net.HttpStatusCode.NoContent);
            }

           return Ok(repo);
        }

        public IHttpActionResult Get(int id)
        {
            Course requestedCourse = repo.Find(c => c.CourseId == id);
            if (requestedCourse == null)
                return NotFound();

            return Ok(requestedCourse);
        }
    }

}
