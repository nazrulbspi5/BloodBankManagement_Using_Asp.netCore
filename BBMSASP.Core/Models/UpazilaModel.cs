using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class UpazilaModel
    {
        [Key]
        public int UpazilaId { get; set; }
        public string UpazilaName { get; set; }
        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public DivisionModel Divisions { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public DistrictModel Districts { get; set; }


    }
}
