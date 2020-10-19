using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace UpmeetProject.Models
{
    [Table("Event")]
    public class Event
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    }
}
