using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StroopTest.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Last name")]
        public string Lastname { get; set; }
        public string Gener { get; set; }
        public int Age { get; set; }
        [Display(Name = "Register date")]
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }
    }
}
