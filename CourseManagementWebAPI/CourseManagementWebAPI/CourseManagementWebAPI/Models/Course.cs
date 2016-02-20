using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CM.UI.MVC.WebAPI.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public int MaxParticipants { get; set; }
        public double? Price { get; set; }
        public DateTime? Date { get; set; }
    }
}