using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EmployerDTOs
{
    public class CreateEmployerDTO : IDTO
    {
        //public int EmployerId { get; set; }
        public List<Company> Companies { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LinkedinUrl { get; set; }
        public string ProfilePhoto { get; set; }
        public string About { get; set; }
        public int AppUserId { get; set; }
        public List<JobAdvertisement> JobAdvertisements { get; set; }
        public List<EmployerDegree> Degrees { get; set; }
    }
}