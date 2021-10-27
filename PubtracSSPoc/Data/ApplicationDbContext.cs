using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PubtracSSPoc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Copyholder> Copyholders { get; set; }
        public DbSet<Manuals> Manuals { get; set; }
        public DbSet<ManualToCopyHolder> ManualToCopyHolders { get; set; }
    }
}
