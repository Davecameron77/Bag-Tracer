using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Models a PD3 node
    /// </summary>
    class Pd3Node
    {
        [Key]
        public int EFId { get; set; }
        public string Id { get; set; }
        public bool IndPhysical { get; set; }
        public string IscId { get; set; }
        public string IscIdReporting { get; set; }
        public string Type { get; set; }
        public string DestinationId { get; set; }
        public string StationId { get; set; }
        public bool IndAutonomousRouting { get; set; }
        public bool IndInitialRegistration { get; set; }
        public bool IndAssignableDestination { get; set; }
        public string LogistictStep { get; set; }
        public string LogisticStepId { get; set; }
        public string PSEmuType { get; set; }
        public bool IndBPMGeneration { get; set; }
        public string LtmId { get; set; }
        public bool IndTrackingPoint { get; set; }
    }
}
