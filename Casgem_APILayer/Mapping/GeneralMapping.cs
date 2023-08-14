using AutoMapper;
using Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs;
using Casgem_DTOLayer.DTOs.Concrete.CompanyDTOs;
using Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.CurriculumVitaeDTOs;
using Casgem_DTOLayer.DTOs.Concrete.DeleteJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.EducationInformationDTOs;
using Casgem_DTOLayer.DTOs.Concrete.EmployerDegreeDTOs;
using Casgem_DTOLayer.DTOs.Concrete.EmployerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.JobAdvertisementDTOs;
using Casgem_DTOLayer.DTOs.Concrete.JobAdvertisementWorkExperienceDTOs;
using Casgem_DTOLayer.DTOs.Concrete.JobApplicationDTOs;
using Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.UpdateJobSeekerDTOs;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_APILayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Employer, CreateEmployerDTO>().ReverseMap();
            CreateMap<Employer, SelectEmployerDTO>().ReverseMap();
            CreateMap<Employer, UpdateEmployerDTO>().ReverseMap();
            CreateMap<Employer, DeleteEmployerDTO>().ReverseMap();

            CreateMap<JobSeeker, CreateJobSeekerDTO>().ReverseMap();
            CreateMap<JobSeeker, SelectJobSeekerDTO>().ReverseMap();
            CreateMap<JobSeeker, UpdateJobSeekerDTO>().ReverseMap();
            CreateMap<JobSeeker, DeleteJobSeekerDTO>().ReverseMap();

            CreateMap<AppUser, CreateAppUserDTO>().ReverseMap();
            CreateMap<AppUser, SelectAppUserDTO>().ReverseMap();
            CreateMap<AppUser, UpdateAppUserDTO>().ReverseMap();
            CreateMap<AppUser, DeleteAppUserDTO>().ReverseMap();

            CreateMap<Company, CreateCompanyDTO>().ReverseMap();
            CreateMap<Company, SelectCompanyDTO>().ReverseMap();
            CreateMap<Company, UpdateCompanyDTO>().ReverseMap();
            CreateMap<Company, DeleteCompanyDTO>().ReverseMap();

            CreateMap<CurriculumVitae, CreateCurriculumVitaeDTO>().ReverseMap();
            CreateMap<CurriculumVitae, SelectCurriculumVitaeDTO>().ReverseMap();
            CreateMap<CurriculumVitae, UpdateCurriculumVitaeDTO>().ReverseMap();
            CreateMap<CurriculumVitae, DeleteCurriculumVitaeDTO>().ReverseMap();

            CreateMap<EmployerDegree, CreateEmployerDegreeDTO>().ReverseMap();
            CreateMap<EmployerDegree, SelectEmployerDegreeDTO>().ReverseMap();
            CreateMap<EmployerDegree, UpdateEmployerDegreeDTO>().ReverseMap();
            CreateMap<EmployerDegree, DeleteEmployerDegreeDTO>().ReverseMap();

            CreateMap<EducationInformation, CreateEducationInformationDTO>().ReverseMap();
            CreateMap<EducationInformation, SelectEducationInformationDTO>().ReverseMap();
            CreateMap<EducationInformation, UpdateEducationInformationDTO>().ReverseMap();
            CreateMap<EducationInformation, DeleteEducationInformationDTO>().ReverseMap();

            CreateMap<JobAdvertisement, CreateJobAdvertisementDTO>().ReverseMap();
            CreateMap<JobAdvertisement, SelectJobAdvertisementDTO>().ReverseMap();
            CreateMap<JobAdvertisement, UpdateJobAdvertisementDTO>().ReverseMap();
            CreateMap<JobAdvertisement, DeleteJobAdvertisementDTO>().ReverseMap();

            CreateMap<JobApplication, CreateJobApplicationDTO>().ReverseMap();
            CreateMap<JobApplication, SelectJobApplicationDTO>().ReverseMap();
            CreateMap<JobApplication, UpdateJobApplicationDTO>().ReverseMap();
            CreateMap<JobApplication, DeleteJobApplicationDTO>().ReverseMap();

            CreateMap<JobAdvertisementWorkExperience, JobAdvertisementCreateWorkExperienceDTO>().ReverseMap();
            CreateMap<JobAdvertisementWorkExperience, JobAdvertisementSelectWorkExperienceDTO>().ReverseMap();
            CreateMap<JobAdvertisementWorkExperience, JobAdvertisementUpdateWorkExperienceDTO>().ReverseMap();
            CreateMap<JobAdvertisementWorkExperience, JobAdvertisementDeleteWorkExperienceDTO>().ReverseMap();
        }
    }
}
