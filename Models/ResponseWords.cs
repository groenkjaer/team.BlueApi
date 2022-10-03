using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.BlueApi.Models
{
    public class ResponseWords
    {
        public int DistinctUniqueWords { get; init; }
        public List<Watchlist>? WatchlistWords { get; set; }
    }
}
