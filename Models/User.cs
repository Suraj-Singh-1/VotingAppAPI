using System;
using System.Collections.Generic;

namespace VotingAppAPI.Models
{
    public partial class User
    {
        public byte[] Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNo { get; set; }
        public int Type { get; set; }
        public string VotedTo { get; set; } = null!;
    }
}
