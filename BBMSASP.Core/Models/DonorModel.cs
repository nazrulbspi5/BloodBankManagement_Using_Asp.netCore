using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class DonorModel
    {
        [Key]
        public int DonorId { get; set; }

        [Required]
        [Display(Name = "User Name *")]
       // [Remote(action: "IsUserNameExist", controller: "Home", HttpMethod = "POST")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Donor Full Name *")]
        public string DonorName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email *")]

        public string Email { get; set; }
        [Required]
        public string Status { get; set; }
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Blood Group *")]
        public int BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }
        [Display(Name = "Date of Birth *")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Display(Name = "Contact Number *")]
        public string ContactNumber { get; set; }
        [Display(Name = "Last Donation Date (Optional)")]
        public DateTime? LastDonationDate { get; set; }
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

        
    }
}
