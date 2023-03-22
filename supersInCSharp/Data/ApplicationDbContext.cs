using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using supersInCSharp.Models;
using System.Collections.Generic;

namespace supersInCSharp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}