using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Architecture.DAL.Modal
{
    public class ApplicationDatabaseContext : IdentityDbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {




        }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblCompany> tblCompanies { get; set; }
        public DbSet<tblVoucherDetail> tblVoucherDetails { get; set; }
        public DbSet<tblVoucherMaster> tblVoucherMasters { get; set; }

    }
}
