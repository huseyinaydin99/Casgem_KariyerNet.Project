﻿using Casgem_DataAccessLayer.Repositories.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Abstract
{
    public interface ICurriculumVitaeDal : IGenericDal<CurriculumVitae>
    {
        public CurriculumVitae GetCurriculumVitaeWithWorkExperience(int id);
        public CurriculumVitae GetCurriculumVitaeWithEducationInformation(int id);
        public void AddCurriculumVitaeForEducationInformation(int curriculumVitaeId, EducationInformation educationInformation);
        public void AddCurriculumVitaeForWorkExperience(int curriculumVitaeId, JobAdvertisementWorkExperience workExperience);

    }
}