﻿using Casgem_DTOLayer.DTOs.Abstract;

namespace Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs
{
    public class SelectAppUserDTO : ISelectDTO
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
    }
}