﻿using Casgem_DataAccessLayer.Abstract;
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
    public class EfJobSeekerDal : GenericRepository<JobSeeker>, IJobSeekerDal
    {
        private readonly KariyerNetDbContext _context;

        public EfJobSeekerDal(KariyerNetDbContext context)
        {
            _context = context;
        }

        public void AddJobSeekerForDegree(int jobSeekerId, EmployerDegree degree)
        {
            var value = _context.JobSeekers.Where(jobSeeker => jobSeeker.JobSeekerId == jobSeekerId).FirstOrDefault();
            //value.Degrees.Add(degree);
            _context.SaveChanges();
        }

        public void AddJobSeekerForDegree(int jobSeekerId, List<EmployerDegree> degrees)
        {
            var value = _context.JobSeekers.Where(jobSeeker => jobSeeker.JobSeekerId == jobSeekerId).FirstOrDefault();
            //degrees.ForEach(degree => value.Degrees.Add(degree));
            _context.SaveChanges();
        }

        public void AddJobSeekerForEducationInformation(int jobSeekerId, EducationInformation educationInformation)
        {
            var value = _context.JobSeekers.Where(jobSeeker => jobSeeker.JobSeekerId == jobSeekerId).FirstOrDefault();
            //value.EducationInformation = educationInformation;
            _context.SaveChanges();
        }

        public void AddJobSeekerForJobApplication(int jobSeekerId, JobApplication jobApplication)
        {
            var value = _context.JobSeekers.Where(jobSeeker => jobSeeker.JobSeekerId == jobSeekerId).FirstOrDefault();
            //value.JobApplications.Add(jobApplication);
            _context.SaveChanges();
        }

        public void AddJobSeekerForJobApplication(int jobSeekerId, List<JobApplication> jobApplications)
        {
            var value = _context.JobSeekers.Where(jobSeeker => jobSeeker.JobSeekerId == jobSeekerId).FirstOrDefault();
            //jobApplications.ForEach(jobApplication => value.JobApplications.Add(jobApplication));
            _context.SaveChanges();
        }

        public List<JobSeeker> GetJobSeekerWithDegree()
        {
            throw new NotImplementedException();
        }

        public JobSeeker GetJobSeekerWithDegree(int id)
        {
            throw new NotImplementedException();
        }

        public JobSeeker GetJobSeekerWithEducationInformation(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobSeeker> GetJobSeekerWithJobApplication()
        {
            //return _context.JobSeekers.Include(jobSeeker => jobSeeker.JobApplications).ToList();
            return null;
        }

        //aslında WHERE Condition'u olan INNER JOIN
        public JobSeeker GetJobSeekerWithJobApplication(int id)
        {
            //return _context.JobSeekers.Include(jobSeeker => jobSeeker.JobApplications).Where(jobSeeker => jobSeeker.JobSeekerId == id).FirstOrDefault();
            return null;
        }

        /*public List<JobSeeker> GetJobSeekerWithJobSeekerJobAdvertisementSearchHistories()
        {
            return _context.JobSeekers.Include(jobSeeker => jobSeeker.JobSeekerJobAdvertisementSearchHistories).ToList();
        }

        public JobSeeker GetJobSeekerWithJobSeekerJobAdvertisementSearchHistories(int id)
        {
            return _context.JobSeekers.Include(jobSeeker => jobSeeker.JobSeekerJobAdvertisementSearchHistories).Where(jobSeeker => jobSeeker.JobSeekerId == id).FirstOrDefault();
        }*/
    }
}