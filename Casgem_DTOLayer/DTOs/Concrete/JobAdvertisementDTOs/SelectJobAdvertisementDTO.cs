﻿using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobAdvertisementDTOs
{
    public class SelectJobAdvertisementDTO : ISelectDTO
    {
        public int JobAdvertisementId { get; set; } //İş ilanı Id
        public string JobDescription { get; set; }//İş tanımı
        public string GeneralQualifications { get; set; } //Genel nitelikler.
        public string Responsibilities { get; set; }
        public string QualificationsAndExperience { get; set; }
        public string Experience { get; set; }
        public string EducationLevel { get; set; }
        public string ForeignLanguage { get; set; }
        public byte ForeignLanguageLevel { get; set; }
        public JobAdvertisementWorkExperience JobAdvertisementWorkExperience { get; set; }
    }
}
