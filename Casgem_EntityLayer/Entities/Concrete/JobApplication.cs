using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş ilanı başvurusu / Başvurular Entity'si.
    public class JobApplication : IEntity
    {
        public int JobApplicationId { get; set; }
        public int JobAdvertisementId { get; set; }
        //public JobAdvertisement JobAdvertisement { get; set; } 
        public int JobSeekerId { get; set; } //İş arayan Id
        //public JobSeeker JobSeeker { get; set; }
        public int EmployerId { get; set; }
        //public Employer Employer { get; set; }
    }
}