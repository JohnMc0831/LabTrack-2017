using System;
using System.Collections.Generic;

namespace LabTrack.Models
{
    public partial class Racks
    {
        public int Id { get; set; }
        public string Rack { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int LocationId { get; set; }
        public int SectionId { get; set; }
        public int FrigId { get; set; }
        public int RackTypeId { get; set; }
    }
}
