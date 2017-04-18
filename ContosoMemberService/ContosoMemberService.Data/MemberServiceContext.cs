using ContosoMemberService.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoMemberService.Data
{
    public class MemberServiceContext : DbContext
    {
        private string _dbConnection;

        public DbSet<Member> Members { get; set; }

        public MemberServiceContext(DbContextOptions<MemberServiceContext> options) : base(options) {
            _dbConnection = options.FindExtension<SqlServerOptionsExtension>().ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnection);
        }
    }
}
