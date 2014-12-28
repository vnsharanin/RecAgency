using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecAgency.Entities
{
    public class SummaryUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SummaryId { get; set; }

        public SummaryUser(int userId, int SummaryId)
        {
            this.UserId = userId;
            this.SummaryId = SummaryId;
        }
    }
}