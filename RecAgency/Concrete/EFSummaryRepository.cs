using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using RecAgency.Entities;
using RecAgency.Abstract;

namespace RecAgency.Concrete
{
    public class EFSummaryRepository:ISummaryRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Summary> Summaries
        {
            get { return context.Summaries; }
        }


    }
}