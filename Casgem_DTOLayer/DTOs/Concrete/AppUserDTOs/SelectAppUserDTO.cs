using Casgem_DTOLayer.DTOs.Abstract;

namespace Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs
{
    public class SelectAppUserDTO : ISelectDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}