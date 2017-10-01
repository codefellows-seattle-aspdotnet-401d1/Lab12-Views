using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab12Cameron.Models
{
    public class Lab12CameronContext : DbContext
    {
        public Lab12CameronContext (DbContextOptions<Lab12CameronContext> options)
            : base(options)
        {
        }

        public DbSet<Lab12Cameron.Models.Student> Student { get; set; }
    }
}
