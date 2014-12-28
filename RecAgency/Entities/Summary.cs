﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecAgency.Entities
{
    public class Summary
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Speciality { get; set; }
        public string Education { get; set; }
        public int ScopeOfWork { get; set; }
        public string Salary { get; set; }
        public string City { get; set; }

        public Summary()
        {
            this.Date = DateTime.Now;
        }

    }
}