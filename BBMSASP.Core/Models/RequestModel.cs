using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class RequestModel
    {   [Key]
        public int RequestId { get; set; }
        [Required]
        [Display(Name = "Name *")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Contact Number *")]
        public string ContactNumber { get; set; }
        [Required]
        [Display(Name = "Blood Group *")]
        public int BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }
        [Required]
        [Display(Name = "Division *")]
        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public DivisionModel Divisions { get; set; }
        [Required]
        [Display(Name = "District *")]
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public DistrictModel Districts { get; set; }
        [Required]
        [Display(Name = "Upazila *")]
        public int UpazilaId { get; set; }
        [ForeignKey("UpazilaId")]
        public UpazilaModel Upazilas { get; set; }
        [Required]
        [Display(Name= "Till Required Date")]
        [DisplayFormat(DataFormatString ="dd-MM-yyyy")]
        public DateTime RequiredDate { get; set; }
        [Required]
        [Display(Name = "Unit of Blood")]
        public int BloodUnit { get; set; }
        [Required]
        [Display(Name = "Hospital Name")]
        public string HospitalName { get; set; }
        public string Status { get; set; }
        public bool IsApproved { get; set; }
    }
}
