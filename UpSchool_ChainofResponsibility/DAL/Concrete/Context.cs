using Microsoft.EntityFrameworkCore;
using UpSchool_ChainofResponsibility.DAL.Entities;

namespace UpSchool_ChainofResponsibility.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-H7B28ES;database=DBUpSchoolChainofResponsibility; integrated security=true");
        }

        public DbSet<BankProcess> BankProcesses { get; set; }
    }
}
