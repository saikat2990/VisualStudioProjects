using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spl2.Models
{
    public class DrugInfoPerStudent
    {


        [Key]
        [Required]
        [DisplayName("Drug name")]
        public string name { get; set; }

        [Required]
        [DisplayName("Ammount")]
        public int amount { get; set; }

        [Required]
        [DisplayName("Student Session")]
        public String Session { get; set; }
    }
}
