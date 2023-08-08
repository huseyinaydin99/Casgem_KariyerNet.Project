using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class JobSeekerManager : IJobSeekerService
    {
        private readonly IJobSeekerDal _jobSeekerDal;

        public JobSeekerManager(IJobSeekerDal jobSeekerDal)
        {
            _jobSeekerDal = jobSeekerDal;
        }

        public List<JobSeeker> GetJobSeekerWithDegree()
        {
            return _jobSeekerDal.GetJobSeekerWithDegree();
        }

        public JobSeeker GetJobSeekerWithDegree(int id)
        {
            return _jobSeekerDal.GetJobSeekerWithDegree(id);
        }

        public JobSeeker GetJobSeekerWithEducationInformation(int id)
        {
            return _jobSeekerDal.GetJobSeekerWithEducationInformation(id);
        }

        public List<JobSeeker> GetJobSeekerWithJobApplication()
        {
            return _jobSeekerDal.GetJobSeekerWithJobApplication();
        }

        public JobSeeker GetJobSeekerWithJobApplication(int id)
        {
            return _jobSeekerDal.GetJobSeekerWithJobApplication(id);
        }

        public void TDelete(JobSeeker t)
        {
            _jobSeekerDal.Delete(t);
        }

        public JobSeeker TGetByID(int id)
        {
            return _jobSeekerDal.GetByID(id);
        }

        public List<JobSeeker> TGetList()
        {
            return _jobSeekerDal.GetList();
        }

        public void TInsert(JobSeeker t)
        {
            _jobSeekerDal.Insert(t);
        }

        public void TUpdate(JobSeeker t)
        {
            _jobSeekerDal.Update(t);
        }
    }
}