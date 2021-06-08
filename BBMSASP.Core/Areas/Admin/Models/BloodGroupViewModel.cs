using BBMSASP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Models
{
    public class BloodGroupViewModel
    {
        public List<BloodGroup> BloodGroupList { get; set; }
        public BloodGroup BloodGroups { get; set; }
    }
}
