using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


// behind the scense for the database
namespace Mission6_Twilso48.Models
{
    public class applicationResponse
    {
        //add required fields and make Movie ID a key
        [Key]
        [Required]
        public int MovieID { get; set; }
  
        [Required(ErrorMessage="Enter Movie Title!")]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        public string Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        // forgien key relationship
        
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
