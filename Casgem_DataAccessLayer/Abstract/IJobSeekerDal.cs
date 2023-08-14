using Casgem_DataAccessLayer.Repositories.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Abstract
{
    public interface IJobSeekerDal : IGenericDal<JobSeeker>
    {
        public List<JobSeeker> GetJobSeekerWithJobApplication();
        public JobSeeker GetJobSeekerWithJobApplication(int id);
        public List<JobSeeker> GetJobSeekerWithDegree();
        public JobSeeker GetJobSeekerWithDegree(int id);
        public JobSeeker GetJobSeekerWithEducationInformation(int id);

        public void AddJobSeekerForJobApplication(int jobSeekerId, JobApplication jobApplication);
        public void AddJobSeekerForJobApplication(int jobSeekerId, List<JobApplication> jobApplications);
        public void AddJobSeekerForDegree(int jobSeekerId, EmployerDegree degree);
        public void AddJobSeekerForDegree(int jobSeekerId, List<EmployerDegree> degrees);
        public void AddJobSeekerForEducationInformation(int jobSeekerId, EducationInformation educationInformation);
    }
}