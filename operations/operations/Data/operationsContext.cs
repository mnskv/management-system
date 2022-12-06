using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using operations.Model;

namespace operations.Data
{
    public class operationsContext : DbContext
    {
        public operationsContext (DbContextOptions<operationsContext> options)
            : base(options)
        {
        }

        public DbSet<operations.Model.product> product { get; set; } = default!;
    }
}
