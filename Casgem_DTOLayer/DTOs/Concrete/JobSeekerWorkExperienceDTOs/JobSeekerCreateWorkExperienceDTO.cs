using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobSeekerWorkExperienceDTOs
{
    public class JobAdvertisementCreateWorkExperienceDTO : IDTO
    {
        //public int JobSeekerWorkExperienceId { get; set; }
        public string? City { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? JobSeekerId { get; set; }
    }
}