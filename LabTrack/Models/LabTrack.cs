using System;
using System.Collections.Generic;

namespace LabTrack.Models
{
    public partial class LabTrack
    {
        public int Id { get; set; }
        public string Rack { get; set; }
        public string Location { get; set; }
        public string Section { get; set; }
        public string Frig { get; set; }
        public DateTime? Entdate { get; set; }
        public DateTime? Expdate { get; set; }
        public string Specnum { get; set; }
        public string Locnum { get; set; }
        public string Comment { get; set; }
    }
}
