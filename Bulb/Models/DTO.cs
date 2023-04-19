using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulb.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsFailed { get; set; }
        public DateTime DateTime { get; set; }
        public Note() { }
        public Note(string description, DateTime dateTime, bool succes) 
        {
            Description = description;
            IsFailed = succes;
            DateTime = dateTime;
        }
    }
}
