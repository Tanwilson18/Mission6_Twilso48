using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Twilso48.Models
{
    public class applicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte age { get; set; }
        public string phone { get; set; }
        public string Major { get; set; }
        public bool Stalker { get; set; }



    }
}
