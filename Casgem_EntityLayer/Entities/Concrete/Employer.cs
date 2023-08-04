using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş veren Entity'si.
    public class Employer : IEntity
    {
        public int EmployerId { get; set; }
        public int CompanyId { get; set; }
        public List<Company> Companies { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LinkedinUrl { get; set; }
        public string ProfilePhoto { get; set; }
        public string About { get; set; }
        public int AppUserId { get; set; } //bir iş veren üye olan kullanıcı ile 1'e 1 ilişkili.
        public AppUser AppUser { get; set; } //bir iş veren üye olan kullanıcı ile 1'e 1 ilişkili.
        public int EmployerJobAdvertisementSearchHistoryId { get; set; }//iş veren geçmişi 1'e çok ilişkili.
        public List<EmployerJobAdvertisementSearchHistory> EmployerJobAdvertisementSearchHistory { get; set; }
        public int JobAdvertisementId { get; set; } //iş veren iş ilanlarına 1'e çok ilişkili.
        public List<JobAdvertisement> JobAdvertisement { get; set; } //iş verenin yayınladığı birden fazla iş ilanı var.
        public int JobApplicationId { get; set; }//iş başvurusu id'si.
        public List<JobApplication> JobApplications { get; set; }
        public int DegreeId { get; set; } //bir iş verenin birden fazla ünvanı olabilir.
        public List<Degree> Degrees { get; set; }
    }
}