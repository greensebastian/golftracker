using System;
using System.Collections.Generic;

namespace Models
{
    public class Hole
    {
        public int Number { get; set; }
        public IEnumerable<Stroke> Strokes { get; set; }
    }
}
