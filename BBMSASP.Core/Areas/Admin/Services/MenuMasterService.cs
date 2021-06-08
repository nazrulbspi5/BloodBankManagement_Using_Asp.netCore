using BBMSASP.Core.Areas.Admin.Models;
using BBMSASP.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Services
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly ApplicationDbContext _dbContext;
        public MenuMasterService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return _dbContext.MenuMasters.AsEnumerable();
        }

        public IEnumerable<MenuMaster> GetMenuMaster(string UserRole)
        {
            var result = _dbContext.MenuMasters.Where(m => m.User_Roll == UserRole).ToList();
            return result;
        }
    }
}
