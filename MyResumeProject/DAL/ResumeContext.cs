
using MyResumeProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace MyResumeProject.DAL
{
    public class ResumeContext : DbContext
    {
        public ResumeContext() : base("ResumeContext")
        {

        }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<Certifications> Certifications { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<VolunteerExperience>VolunteerExperience { get; set; }
        public DbSet<References>References { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}