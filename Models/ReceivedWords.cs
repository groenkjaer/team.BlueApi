using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.BlueApi.Attributes;

namespace team.BlueApi.Models
{
    public class ReceivedWords
    {
        [MaxLengthSubstring(100)]
        public string Text { get; set; } = null!;
    }
}
