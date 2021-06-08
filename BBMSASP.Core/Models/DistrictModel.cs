using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class DistrictModel
    {
        [Key]
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public DivisionModel Divisions { get; set; }
    }
}
