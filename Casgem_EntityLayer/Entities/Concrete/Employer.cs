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
        public List<Company> Companies { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LinkedinUrl { get; set; }
        public string ProfilePhoto { get; set; }
        public string About { get; set; }
        public int AppUserId { get; set; }
        public List<JobAdvertisement> JobAdvertisements { get; set; } 
        public List<EmployerDegree> Degrees { get; set; }
    }
}