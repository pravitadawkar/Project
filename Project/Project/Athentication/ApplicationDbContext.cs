using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Athentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

          //  builder.Entity<AgreementTemplate>()
          //.HasMany(el => el.Agreementtype)
          //.WithOne(e => e.Agreementtemplate)
          //.HasForeignKey(e => e.TypeId);

          //  builder.Entity<AgreementCategory>()
          // .HasMany(el => el.Agreementtype)
          // .WithOne(e => e.AgreementCategory)
          // .HasForeignKey(e => e.TypeId);

           // builder.Entity<AgreementCategory>()
           //.HasOne(el => el.AgreementTemplate)
           //.WithOne(e => e.AgreementCategory)
           //.HasForeignKey(el => el.CategoryId);
        }
        public DbSet<AgreementType> AgreementTypes { get; set; }
        public DbSet<AgreementCategory> AgreementCategorys { get; set; }
        public DbSet<AgreementTemplate> AgreementTemplates { get; set; }
    }
}
