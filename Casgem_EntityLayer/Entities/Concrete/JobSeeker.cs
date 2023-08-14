using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    public class JobSeeker : IEntity
    {
        public int JobSeekerId { get; set; }
        public CurriculumVitae? CurriculumVitae { get; set; }

        public int? AppUserId { get; set; }
    }
}