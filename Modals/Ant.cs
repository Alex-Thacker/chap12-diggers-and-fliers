using System;
using System.Collections.Generic;

namespace diggersandfliers {
    public class Ant : IMoveOnGround {
        public bool WillWalkOnGround { get; set; }
        public int LegCount { get; set; }
    }
}