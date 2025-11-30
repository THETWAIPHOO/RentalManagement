using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentalManagement.Domain;

namespace RentalManagement.Data
{
    public class RentalManagementContext : DbContext
    {
        public RentalManagementContext (DbContextOptions<RentalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<RentalManagement.Domain.Colour> Colour { get; set; } = default!;
    }
}
