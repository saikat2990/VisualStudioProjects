using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asp.netMvcTuitorial.Models
{   
    [Table("EmployeeData")]
    public class EmployeeData
    {
        [Key]
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public int Salary{ get; set; }
        public string Email { get; set; }
        public string PhnNumber { get; set;}

    };
}