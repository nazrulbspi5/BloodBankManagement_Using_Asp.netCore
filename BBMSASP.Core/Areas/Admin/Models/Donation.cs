using BBMSASP.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public int DonorId { get; set; }
        [ForeignKey("DonorId")]
        public DonorModel Donors { get; set; }
        [Required]
        [Display(Name = "Donation Date")]
        public DateTime DonationDate { get; set; }
        [Display(Name = "Times Of Donation")]
        public int TimesOfDonation { get; set; }
        public string Location { get; set; }
    }
}
