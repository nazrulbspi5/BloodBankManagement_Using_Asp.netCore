using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Models
{
    public class DonorCounterModel
    {
        public int APositive { get; set; }
        public int ANegative { get; set; }
        public int BPositive { get; set; }
        public int BNegative { get; set; }
        public int ABPositive { get; set; }
        public int ABNegative { get; set; }
        public int OPositive { get; set; }
        public int ONegative { get; set; }
        public int TotalDonor { get; set; }
        public int TotalRequest { get; set; }
        public int PendingRequest { get; set; }
        public int ApprovedRequest { get; set; }
        public int RejectRequest { get; set; }
        public int AcceptRequest { get; set; }

    }
}
