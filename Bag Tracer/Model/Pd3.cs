using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Class to model a PD3 file
    /// </summary>
    class Pd3
    {
        [Key]
        public int EFId { get; set; }
        public string Version { get; set; }
        public List<Pd3Svg> Pd3Svgs { get; set; }
        public List<Pd3Node> Pd3Nodes { get; set; }
        public List<Pd3Station> Pd3Stations { get; set; }
        public List<Pd3RouteSegment> Pd3RouteSegments { get; set; }
        public List<Pd3StatusSegment> Pd3StatusSegments { get; set; }
    }
}
