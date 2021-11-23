using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandaRestApi
{
    public class JobView
    {
        
        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        
    }
}
