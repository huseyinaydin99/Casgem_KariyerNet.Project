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
    public class EmployerDegree : IEntity
    {
        public int EmployerDegreeId { get; set; } 
        public int? EmployerId { get; set; }
    }
}