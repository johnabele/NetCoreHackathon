using ContosoClaimService.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConotosClaimService.Data
{
    public class ClaimServiceContext : DbContext
    {
        public DbSet<Claim> Claims { get; set; }
        public ClaimServiceContext(DbContextOptions<ClaimServiceContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claim>()
                .ToTable("Claim");

            //modelBuilder.Entity<Claim>().Property(i => i.AmountBilled)
            //    .HasColumnType("Money");
            //modelBuilder.Entity<Claim>().Property(i => i.AmountMemberResponsibility)
            //    .HasColumnType("Money");
        }
    }
}
