using IsKapisi.Business.Abstract;
using IsKapisi.Core.ViewModels;
using IsKapisi.Data.Abstract;
using IsKapisi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKapisi.Business.Concrete
{
    public class JobManager : IJobService

    {

        private IJobRepository _jobRepository;

        public JobManager(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public void Create(JobViewModel model)
        {
            throw new NotImplementedException();
        }

        public List<JobViewModel> GetAll(bool? isHome = null, bool? isActive = null, bool? isDelete = null)
        {
            List<Job> jobs;
            if (isHome == null)
            {
                jobs = _jobRepository.GetAll();
            }
            else
            {
                jobs = _jobRepository.GetHomePageProducts(isHome);
            }
            List<JobViewModel> jobViewModels = jobs
                .Select(p => new JobViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Url = p.Url,
                    ImageUrl = p.ImageUrl,
                    Properties = p.Properties
                }).ToList();
            return jobViewModels;


        }

        public JobViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDelete(JobViewModel model)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(JobViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(JobViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
