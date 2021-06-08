using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class DivisionModel
    {
        [Key]
        public int DivisionId { get; set; }
        [Display(Name ="Division Name")]
        [Required]
        public string DivisionName { get; set; }
    }
}
