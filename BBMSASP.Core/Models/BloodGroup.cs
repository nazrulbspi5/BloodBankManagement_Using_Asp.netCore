using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class BloodGroup
    {
        public int BloodGroupId { get; set; }
        [Required]
        [Display(Name = "Blood Group")]
        public string GroupName { get; set; }
    }
}
