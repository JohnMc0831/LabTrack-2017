using System;
using System.Collections.Generic;

namespace LabTrack.Models
{
    public partial class Specs
    {
        public int Id { get; set; }
        public string Specnum { get; set; }
        public int RackId { get; set; }
        public string Comment { get; set; }
        public int? LocationNumber { get; set; }
        public string Position { get; set; }
    }
}
