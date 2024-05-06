using System;
using System.Collections.Generic;

namespace VotingAppAPI.Models
{
    public partial class Candidate
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int VoteCounrt { get; set; }
    }
}
