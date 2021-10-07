using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AR.Models;

    public class ARGameContext : DbContext
    {
        public ARGameContext (DbContextOptions<ARGameContext> options)
            : base(options)
        {
        }

        public DbSet<AR.Models.Game> Game { get; set; }
    }
