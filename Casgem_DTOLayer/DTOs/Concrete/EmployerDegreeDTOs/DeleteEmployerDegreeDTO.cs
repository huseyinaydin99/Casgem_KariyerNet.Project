using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EmployerDegreeDTOs
{
    public class DeleteEmployerDegreeDTO : IDTO
    {
        public int EmployerDegreeId { get; set; }
    }
}
