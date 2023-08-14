using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs
{
    public class SelectJobSeekerDTO : ISelectDTO
    {
        public int JobSeekerId { get; set; }
        public CurriculumVitae? CurriculumVitae { get; set; }
    }
}
