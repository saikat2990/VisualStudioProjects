using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spl2.Models
{
    public class DailyStudentServiceList
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Student Session")]
        public string Session { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Student Name")]
        public string studentname { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Email")]
        public string email { get; set; }

        [Column(TypeName = "varchar(600)")]
        [Required]
        [DisplayName("ProblemDetails")]
        public string problemDetails { get; set; }

        [Column(TypeName = "varchar(7000)")]
        [Required]
        [DisplayName("DrugList")]
        public string DrugList { get; set; }

        public List<DrugInfoPerStudent> DrugInfoPerStudents { get; set; }

    }
}
