using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public DateTime DateTime { get; set; }

        public TimeSpan Duration { get; set; }

    }
}
