using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class ActsIn
    {
        public int Id { get; set; }

        public Actor Actor { get; set; } = null!;

        public Movie Movie { get; set; } = null!;
    }
}
