using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Models a PD3 status segment
    /// </summary>
    class Pd3StatusSegment
    {
        [Key]
        public int EFId { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string TransportType { get; set; }
        public string MaxHoldingCapacity { get; set; }
    }
}
