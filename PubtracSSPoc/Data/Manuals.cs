 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PubtracSSPoc.Data
{
    public class Manuals
    {
        public int Id { get; set; }


        [Required]
        public string Manual { get; set; }
        [Required]
        public string ManualNo  { get; set; }

        public string LastRevNo { get; set; }

        public string LastBullNo { get; set; }

        public string LastChangeNo { get; set; }
    }
}
