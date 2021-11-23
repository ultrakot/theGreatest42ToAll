
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandaRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobSearchController : ControllerBase
    {

        [EnableCors]
        [HttpGet]
        public IEnumerable<JobTitle> Get()
        {
            using (var db = new JobSearchContext())
            {
                var job_titles = db.Test_JobTitles.ToList();
                    
                return job_titles;
            }         
        }

        [EnableCors]
        [HttpGet("getjobs/{id}")]
        public IEnumerable<JobView> GetJobByTitleId(int id)
        {
            using (var db = new JobSearchContext())
            {
                var jobs = db.Jobs_view.Where(j => j.JobTitleId == id)
                    .ToList();                
                return jobs;
            }
        }

    }
}
