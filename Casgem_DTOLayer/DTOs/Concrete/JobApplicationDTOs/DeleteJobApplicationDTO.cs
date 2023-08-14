using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobApplicationDTOs
{
    public class DeleteJobApplicationDTO : IDTO
    {
        public int JobApplicationId { get; set; }
    }
}
