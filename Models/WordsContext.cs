using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.BlueApi.Models
{
    public class WordsContext : DbContext
    {
        public WordsContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Words> Words { get; set; } = null!;
        public DbSet<WatchlistWord> Watchlist { get; set; } = null!;
    }
}
