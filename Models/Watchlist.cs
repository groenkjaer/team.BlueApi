using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.BlueApi.Models
{
    public class Watchlist
    {
        [Key]
        [MaxLength(100)]
        public string? WatchedWord { get; set; }
    }
}
