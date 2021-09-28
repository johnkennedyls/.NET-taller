using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerRPC.Pages.Models;

namespace TallerRPC.Data
{
    public class TallerRPCContext : DbContext
    {
        public TallerRPCContext (DbContextOptions<TallerRPCContext> options)
            : base(options)
        {
        }

        public DbSet<TallerRPC.Pages.Models.Account> Account { get; set; }
    }
}
