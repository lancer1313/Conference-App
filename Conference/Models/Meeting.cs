using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Section { get; set; } = null!;
        public string Date { get; set; } = null!;
        public List<Person> People { get; set; } = new List<Person>();
    }
}
