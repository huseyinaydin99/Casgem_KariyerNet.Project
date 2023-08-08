using Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.DeleteJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.UpdateJobSeekerDTOs;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Abstract
{
    public interface IJobSeekerController
    {
        public Task<IActionResult> AddJobSeeker(CreateJobSeekerDTO createJobSeekerDTO);
        public Task<IActionResult> UpdateJobSeeker(UpdateJobSeekerDTO createJobSeekerDTO);
        public Task<IActionResult> DeleteJobSeeker(DeleteJobSeekerDTO deleteJobSeekerDTO);
        public Task<IActionResult> GetJobSeeker(SelectJobSeekerDTO selectJobSeekerDTO);


        public Task<IActionResult> GetJobSeekerWithJobApplication();
        public Task<IActionResult> GetJobSeekerWithJobApplication(int id);
        public Task<IActionResult> GetJobSeekerWithDegree();
        public Task<IActionResult> GetJobSeekerWithDegree(int id);
        public Task<IActionResult> GetJobSeekerWithEducationInformation(int id);
    }
}