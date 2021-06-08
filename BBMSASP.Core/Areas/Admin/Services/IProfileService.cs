using BBMSASP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Services
{
    public interface IProfileService
    {
        IEnumerable<DonorModel> GetDonorProfiles();
        DonorModel Donors(string UserName);
    }
}
