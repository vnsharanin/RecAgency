using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecAgency.Entities
{
    public class UserEmpl
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VacancyId { get; set; }

        public UserEmpl(int userId, int vacancyId)
        {
            this.UserId = userId;
            this.VacancyId = vacancyId;
        }
    }
}