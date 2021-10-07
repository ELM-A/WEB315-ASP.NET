using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AR.Models;

    public class ARGamesContext : DbContext
    {
        public ARGamesContext (DbContextOptions<ARGamesContext> options)
            : base(options)
        {
        }

        public DbSet<AR.Models.Game> Game { get; set; }
    }
