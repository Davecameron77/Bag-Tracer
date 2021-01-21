using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Models a PD3 Station
    /// </summary>
    class Pd3Station
    {
        [Key]
        public int EFId { get; set; }
        public string Id { get; set; }
        public string DestinationId { get; set; }
        public string EndUserId { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string MaximumCapacity { get; set; }
        public string LogisticStepRank { get; set; }
        public bool IndReportAvailability { get; set; }
        public bool IndEquipmentAvailability { get; set; }
        public bool IndUpdateTracking { get; set; }
    }
}
