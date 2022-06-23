using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjZalSongs.Models
{
    public class SongsDbContext:DbContext
    {
        public SongsDbContext(DbContextOptions<SongsDbContext> options) : base(options)
        {


        }

        public DbSet<Songs>Songs { get; set; }

    }
}
