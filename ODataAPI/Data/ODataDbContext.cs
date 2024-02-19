using Microsoft.EntityFrameworkCore;
using ODataAPI.Data.Entities;

namespace ODataAPI.Data
{
    public class ODataDbContext : DbContext
    {
        public ODataDbContext(DbContextOptions<ODataDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeAddresses> EmployeeAddresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAddresses>()
            .HasOne(_ => _.Employee)
            .WithMany(_ => _.EmployeeAddresses)
            .HasForeignKey(_ => _.EmployeeId);
        }
    }
}
