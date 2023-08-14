using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.Context;
using Casgem_DataAccessLayer.Repositories.Concrete;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Concrete.EntityFramework
{
    public class EfJobApplicationDal : GenericRepository<JobApplication>, IJobApplicationDal
    {
        private readonly KariyerNetDbContext _context;

        public EfJobApplicationDal(KariyerNetDbContext context)
        {
            _context = context;
        }

        public JobApplication GetJobApplicationWithEmployer(int id)
        {
            throw new NotImplementedException();
        }

        public JobApplication GetJobApplicationWithJobAdvertisement(int id)
        {
            throw new NotImplementedException();
        }

        public JobApplication GetJobApplicationWithJobSeeker(int id)
        {
            throw new NotImplementedException();
        }
    }
}