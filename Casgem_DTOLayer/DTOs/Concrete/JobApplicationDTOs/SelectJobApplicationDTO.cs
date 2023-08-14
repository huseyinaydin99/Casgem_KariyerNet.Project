using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobApplicationDTOs
{
    public class SelectJobApplicationDTO : ISelectDTO
    {
        public int? JobApplicationId { get; set; }
        public int? JobAdvertisementId { get; set; }
        public int? JobSeekerId { get; set; }
    }
}
