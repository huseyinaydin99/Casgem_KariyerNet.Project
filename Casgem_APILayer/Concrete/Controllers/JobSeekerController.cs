using Casgem_APILayer.Abstract;
using Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.DeleteJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.UpdateJobSeekerDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase, IJobSeekerController
    {
        public Task<IActionResult> AddJobSeeker(CreateJobSeekerDTO createJobSeekerDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeleteJobSeeker(DeleteJobSeekerDTO deleteJobSeekerDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetJobSeeker(SelectJobSeekerDTO selectJobSeekerDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetJobSeekerWithDegree()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetJobSeekerWithDegree(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetJobSeekerWithEducationInformation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetJobSeekerWithJobApplication()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetJobSeekerWithJobApplication(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateJobSeeker(UpdateJobSeekerDTO createJobSeekerDTO)
        {
            throw new NotImplementedException();
        }
    }
}
