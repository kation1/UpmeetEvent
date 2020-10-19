using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace UpmeetProject.Models
{ 
    [Table("Favorite")]
    public class Favorite
    {
        [Key]
        public int Id { get; set; }  //May need to be long
        public string UserId { get; set; }
        public int EventId { get; set; }
    }
}
