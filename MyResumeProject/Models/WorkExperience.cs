using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResumeProject.Models
{
    public class WorkExperience
    {
        public int ID { get; set; }
        public string Employer { get; set; }
        public string JobDuties { get; set; }
        public DateTime EmploymentDates { get; set; }

        public virtual ICollection<WorkExperience> WorkHistory {get; set;}



    }
}