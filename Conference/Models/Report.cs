using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Theme { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;
    }
}
