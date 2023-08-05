using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.EntityFramework;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class EmployerManager : IEmployerService
    {
        private readonly IEmployerDal _employerDal;

        public EmployerManager(IEmployerDal employerDal)
        {
            _employerDal = employerDal;
        }

        public void TDelete(Employer t)
        {
            _employerDal.Delete(t);
        }

        public Employer TGetByID(int id)
        {
            return _employerDal.GetByID(id);
        }

        public List<Employer> TGetList()
        {
            return _employerDal.GetList();
        }

        public void TInsert(Employer t)
        {
            _employerDal.Insert(t);
        }

        public void TUpdate(Employer t)
        {
            _employerDal.Update(t);
        }
    }
}
