using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Models
{
    public class BlogModel
    {
        [Key]
        public int BlogId { get; set; }
        [Display(Name ="Title")]
        [Required]
        public string BlogTitle { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Blog Content")]
        [Required]
        public string BlogContent { get; set; }
        public DateTime PostDate { get; set; }
        public string EntryBy { get; set; }
    }
}
