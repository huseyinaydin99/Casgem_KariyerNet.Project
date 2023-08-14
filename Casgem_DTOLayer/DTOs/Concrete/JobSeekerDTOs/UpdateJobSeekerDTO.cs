using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.UpdateJobSeekerDTOs
{
    public class UpdateJobSeekerDTO : IDTO
    {
        public int JobSeekerId { get; set; }
        public CurriculumVitae? CurriculumVitae { get; set; }
    }
}