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