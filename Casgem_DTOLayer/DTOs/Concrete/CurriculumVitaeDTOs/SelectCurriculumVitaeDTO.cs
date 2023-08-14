﻿using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CurriculumVitaeDTOs
{
    public class SelectCurriculumVitaeDTO : ISelectDTO
    {
        public int CurriculumVitaeId { get; set; }
        public string? CVName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? ProfilePhotoUrl { get; set; }
        public string? Nationality { get; set; }
        public string? DriverLicence { get; set; }
        public string? MilitaryStatus { get; set; }
        public bool? DisabilityStatus { get; set; }
        public string? SummaryInformation { get; set; }
        public string? Abilities { get; set; }
        public JobSeekerWorkExperience? WorkExperience { get; set; }
        public EducationInformation? EducationInformation { get; set; }
        public List<JobSeekerDegree>? Degrees { get; set; }
    }
}
