using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Services
{
    public class ProfileService : IProfileService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProfileService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<DonorModel> GetDonorProfiles()
        {
            return _dbContext.Donors.AsEnumerable();
        }

        public DonorModel Donors(string UserName)
        {
            var result = _dbContext.Donors.Where(m => m.UserName == UserName).FirstOrDefault();
            return result;
        }
    }
}
