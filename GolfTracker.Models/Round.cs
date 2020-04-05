using System.Collections.Generic;

namespace Models
{
    public class Round
    {
        public string Name { get; set; }
        public IEnumerable<Hole> Holes { get; set; }
    }
}
