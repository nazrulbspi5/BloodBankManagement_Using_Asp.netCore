using BBMSASP.Core.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Services
{
    public interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
        IEnumerable<MenuMaster> GetMenuMaster(string UserRole);
    }
}
