using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResumeProject.Models
{
    public class VolunteerExperience
    {
        public string VolunteerOrganization { get; set; }
        public string VolunteerDuties { get; set; }
        public DateTime VolunteerDates { get; set; }
    }
}