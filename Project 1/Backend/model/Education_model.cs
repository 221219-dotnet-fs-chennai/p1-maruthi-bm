using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Education_model
    {
        public int TrainerId { get; set; }

        public int EducationId { get; set; }

        public string? Degree { get; set; }

        public string? InstituteName { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public int? Grade { get; set; }

        public decimal? Cgpa { get; set; }
    }
}
