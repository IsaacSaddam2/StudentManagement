using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsApi.Models
{
    public class AssessmentDetails
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public string SubjectName { get; set; }
        public int Marks { get; set; }
    }
}
