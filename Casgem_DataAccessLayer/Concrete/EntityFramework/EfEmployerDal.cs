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
    public class EfEmployerDal : GenericRepository<Employer>, IEmployerDal
    {
        private readonly KariyerNetDbContext _context;

        public EfEmployerDal(KariyerNetDbContext context)
        {
            _context = context;
        }

        public List<Employer> GetEmployerWithDegrees()
        {
            return _context.Employers.Include(employer => employer.Degrees).ToList();
        }

        public Employer GetEmployerWithDegree(int id)
        {
            return _context.Employers.Include(employer => employer.Degrees).Where(employer => employer.EmployerId == id).FirstOrDefault();
        }

        public List<Employer> GetEmployerWithJobAdvertisements()
        {
            return _context.Employers.Include(employer => employer.JobAdvertisements).ToList();
        }

        public Employer GetEmployerWithJobAdvertisement(int id)
        {
            return _context.Employers.Include(employer => employer.JobAdvertisements).Where(employer => employer.EmployerId == id).FirstOrDefault();
        }


        public List<Employer> GetEmployerWithJobAdvertisementSearchHistories()
        {
            return _context.Employers.Include(employer => employer.EmployerJobAdvertisementSearchHistory).ToList();
        }

        public Employer GetEmployerWithJobAdvertisementSearchHistory(int id)
        {
            return _context.Employers.Include(employer => employer.EmployerJobAdvertisementSearchHistory).Where(employer => employer.EmployerId == id).FirstOrDefault();
        }

        public Employer GetEmployerWithCompany(int id)
        {
            return _context.Employers.Include(employer => employer.Companies).Where(employer => employer.EmployerId == id).FirstOrDefault();
        }

        public List<Employer> GetEmployerWithCompanies()
        {
            return _context.Employers.Include(employer => employer.Companies).ToList();
        }
    }
}