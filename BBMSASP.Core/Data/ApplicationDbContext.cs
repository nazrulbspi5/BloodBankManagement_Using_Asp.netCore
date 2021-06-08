using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BBMSASP.Core.Models;
using BBMSASP.Core.Areas.Admin.Models;

namespace BBMSASP.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HomePageModels> HomePage { get; set; }
        public DbSet<AboutUsModels> AboutUs { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<DonorModel> Donors { get; set; }
        public DbSet<DivisionModel> Divisions { get; set; }
        public DbSet<DistrictModel> Districts { get; set; }
        public DbSet<UpazilaModel> Upazilas { get; set; }
        public DbSet<BlogModel> Blogs { get; set; }
        public DbSet<MenuMaster> MenuMasters { get; set; }
        public DbSet<RequestModel> BloodRequests { get; set; }
        public DbSet<ContactUS> ContactUs { get; set; }
        public DbSet<Donation> Donations { get; set; }

    }
}
