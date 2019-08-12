using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StroopTest.Models
{
    public class ActivityRecord
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Phase { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }
        public string Ink { get; set; }
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
    }
}
