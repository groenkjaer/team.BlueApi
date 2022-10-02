using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.BlueApi.Models
{
    public class Words
    {
        public string? Text { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Words words &&
                   Text == words.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text);
        }
    }
}
