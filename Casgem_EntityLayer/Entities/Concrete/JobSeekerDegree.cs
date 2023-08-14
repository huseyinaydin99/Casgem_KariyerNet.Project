using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ünvan!!!!
namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş verenlerin ve iş arayanların ünvan Entity'si.
    public class JobSeekerDegree : IEntity
    {
        public int JobSeekerDegreeId { get; set; } 
        public int? JobSeekerId { get; set; }
    }
}