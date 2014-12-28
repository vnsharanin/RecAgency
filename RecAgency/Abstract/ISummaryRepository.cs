using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecAgency.Entities;

namespace RecAgency.Abstract
{
    public  interface ISummaryRepository
    {
        IQueryable<Summary> Summaries { get; }
        IQueryable<SummaryUser> SummaryUser {get;}
        void AddSummary(Summary summary, int userId);
        Summary DeleteSummary(int summaryId);
    }
}
