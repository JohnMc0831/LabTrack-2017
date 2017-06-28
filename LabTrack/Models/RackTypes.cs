using System;
using System.Collections.Generic;

namespace LabTrack.Models
{
    public partial class RackTypes
    {
        public int Id { get; set; }
        public string RackType { get; set; }
        public int RackRows { get; set; }
        public int RackCols { get; set; }
    }
}
