using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş ilanı arama kısmı geçmişi Entity'si.
    public class JobSeekerJobAdvertisementSearchHistory : IEntity
    {
        public int EmployerJobAdvertisementSearchHistoryId { get; set; }
        public string Word { get; set; }
        public int JobSeeker { get; set; }
        public JobSeeker MyProperty { get; set; }
    }
}
