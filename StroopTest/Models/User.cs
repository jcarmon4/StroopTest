using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StroopTest.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Gener { get; set; }
        public int Age { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }
    }
}
