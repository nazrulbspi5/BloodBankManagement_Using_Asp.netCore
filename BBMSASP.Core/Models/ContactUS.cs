using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class ContactUS
    {
        [Key]
        public int ContactUSId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsRead { get; set; }
    }
}
