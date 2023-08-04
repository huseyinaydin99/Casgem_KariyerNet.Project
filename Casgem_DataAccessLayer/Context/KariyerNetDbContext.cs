using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Context
{
    public class KariyerNetDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-13123BI; Initial Catalog = CasgemKariyerNetDb; Integrated Security = true;");
        }        

        public DbSet<Company> Companies { get; set; } //Şirketler tablosu.
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; } //CV tablosu.
        public DbSet<Degree> Degrees { get; set; } //Ünvan tablosu.
        public DbSet<EducationInformation> EducationInformations { get; set; }//Eğitim bilgileri.
        public DbSet<Employer> Employers { get; set; }//İş verenler tablousu
        //arama geçmişi.
        //işveren iş ilanı arama geçmişi.
        public DbSet<EmployerJobAdvertisementSearchHistory> EmployerJobAdvertisementSearchHistories { get; set; }
        public DbSet<JobAdvertisement> JobAdvertisements { get; set; }//iş ilanları tablosu.
        public DbSet<JobApplication> JobApplications { get; set; } //iş başvuruları tablosu.
        public DbSet<JobSeeker> JobSeekers { get; set; } //iş arayanlar tablosu.
        //arama geçmişi.
        //iş arayanını yapmış olduğu aramalarının gelmişlerinin geçmişlerinin tutulduğu tablodur.
        public DbSet<JobSeekerJobAdvertisementSearchHistory> JobSeekerJobAdvertisementSearchHistories { get; set; }
        //iş ilanında yayınlanan iş verenler tarafından istenilen ve beklenen iş deneyimleri tablosudur.
        public DbSet<WorkExperience> WorkExperiences { get; set; }
    }


}