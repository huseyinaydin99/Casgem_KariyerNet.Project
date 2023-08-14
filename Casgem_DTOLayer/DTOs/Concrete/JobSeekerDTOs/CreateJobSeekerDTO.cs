using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs
{
    public class CreateJobSeekerDTO : IDTO
    {
        public int JobSeekerId { get; set; }
        public CurriculumVitae? CurriculumVitae { get; set; }
        public int? AppUserId { get; set; }
    }
}