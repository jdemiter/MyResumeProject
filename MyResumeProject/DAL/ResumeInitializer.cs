using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyResumeProject.Models;

namespace MyResumeProject.DAL
{
    public class ResumeInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ResumeContext>
        {
        protected override void Seed(ResumeContext context)
        {
            var WorkExperience = new List<WorkExperience>
            {
                new WorkExperience {Employer="Verizon", JobDuties="Sr Trainer", EmploymentDates=DateTime.Parse("2010-01-17") },
            };

            WorkExperience.ForEach(w => context.WorkExperience.Add(w));
            context.SaveChanges();
            var Certifications = new List<Certifications>
            {
                new Certifications {Certification ="CompTIA A+", CertificationDate=DateTime.Parse("2015-05-20") },
            };
            Certifications.ForEach(w => context.Certifications.Add(w));
            context.SaveChanges();
            var Education = new List<Education>
            {
                new Education {SchoolName="Arizona State University", DegreeReceived="BA Spanish Literature", DateReceived=DateTime.Parse("2003-5-20") },
            };
            Education.ForEach(w => context.Education.Add(w));
            context.SaveChanges();
            var VolunteerExperience = new List<VolunteerExperience>
            {
                new VolunteerExperience {VolunteerOrganization="El Paso Public Library", VolunteerDuties="ESOL Instructor", VolunteerDates=DateTime.Parse("2010-01-10") },
            };
            VolunteerExperience.ForEach(w => context.VolunteerExperience.Add(w));
            context.SaveChanges();
            var References = new List<References>
            {
                new References {Name="Sue Andres", Company="Verizon", TelephoneNumber="480-216-1234" },
            };
            References.ForEach(w => context.References.Add(w));
            context.SaveChanges();
        }
    }
}