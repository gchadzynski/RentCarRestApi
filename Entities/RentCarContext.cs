using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RentCarContext : DbContext
    {
        public RentCarContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Cars> Cars { get; set; }

        public DbSet<Rents> Rents { get; set; }
    }
}
