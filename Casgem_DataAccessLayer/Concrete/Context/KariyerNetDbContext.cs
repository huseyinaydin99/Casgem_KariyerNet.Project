using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Concrete.Context
{
    public class KariyerNetDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-13123BI; Initial Catalog = CasgemKariyerNetDb; Integrated Security = true;");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EducationInformation>()
            .HasOne(a => a.JobSeeker)
            .WithOne(a => a.EducationInformation)
            .HasForeignKey<JobSeeker>(c => c.EducationInformationId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkExperience>()
            .HasOne(a => a.JobAdvertisement)
            .WithOne(a => a.WorkExperience)
            .HasForeignKey<JobAdvertisement>(c => c.WorkExperienceId)
            .OnDelete(DeleteBehavior.Restrict);
        }*/

        public DbSet<Company> Companies { get; set; } //Şirketler tablosu.
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; } //CV tablosu.
        public DbSet<EmployerDegree> Degrees { get; set; } //Ünvan tablosu.
        public DbSet<EducationInformation> EducationInformations { get; set; }//Eğitim bilgileri.
        public DbSet<Employer> Employers { get; set; }//İş verenler tablousu
        public DbSet<JobAdvertisement> JobAdvertisements { get; set; }//iş ilanları tablosu.
        public DbSet<JobApplication> JobApplications { get; set; } //iş başvuruları tablosu.
        public DbSet<JobSeeker> JobSeekers { get; set; } //iş arayanlar tablosu.
        public DbSet<JobAdvertisementWorkExperience> WorkExperiences { get; set; } //iş deneyimi tablosu.
    }


}