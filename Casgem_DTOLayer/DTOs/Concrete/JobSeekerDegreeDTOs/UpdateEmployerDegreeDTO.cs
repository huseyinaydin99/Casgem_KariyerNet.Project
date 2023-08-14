using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobSeekerDegreeDTOs
{
    public class UpdateJobSeekerDegreeDTO : IDTO
    {
        public int JobSeekerDegreeId { get; set; }
        public int? JobSeekerId { get; set; }
    }
}