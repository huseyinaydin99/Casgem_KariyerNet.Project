using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class DegreeManager : IDegreeService
    {
        private readonly IDegreeDal _degreeDal;

        public DegreeManager(IDegreeDal degreeDal)
        {
            _degreeDal = degreeDal;
        }

        public void TDelete(EmployerDegree t)
        {
            _degreeDal.Delete(t);
        }

        public EmployerDegree TGetByID(int id)
        {
            return _degreeDal.GetByID(id);
        }

        public List<EmployerDegree> TGetList()
        {
            return _degreeDal.GetList();
        }

        public void TInsert(EmployerDegree t)
        {
            _degreeDal.Insert(t);
        }

        public void TUpdate(EmployerDegree t)
        {
            _degreeDal.Update(t);
        }
    }
}
