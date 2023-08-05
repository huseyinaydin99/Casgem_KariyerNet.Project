using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.EntityFramework;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class JobAdvertisementManager : IJobAdvertisementService
    {
        private readonly IJobAdvertisementDal _jobAdvertisementDal;

        public JobAdvertisementManager(IJobAdvertisementDal jobAdvertisementDal)
        {
            _jobAdvertisementDal = jobAdvertisementDal;
        }

        public void TDelete(JobAdvertisement t)
        {
            _jobAdvertisementDal.Delete(t);
        }

        public JobAdvertisement TGetByID(int id)
        {
            return _jobAdvertisementDal.GetByID(id);
        }

        public List<JobAdvertisement> TGetList()
        {
            return _jobAdvertisementDal.GetList();
        }

        public void TInsert(JobAdvertisement t)
        {
            _jobAdvertisementDal.Insert(t);
        }

        public void TUpdate(JobAdvertisement t)
        {
            _jobAdvertisementDal.Update(t);
        }
    }
}
