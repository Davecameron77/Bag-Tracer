using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Models a PD3 Route Segment
    /// </summary>
    class Pd3RouteSegment
    {
        [Key]
        public int EFId { get; set; }
        public string Id { get; set; }
        public bool IndPhysical { get; set; }
        public string NodeIdStart { get; set; }
        public string NodeIdEnd { get; set; }
        public string StatusSegmentId { get; set; }
        public bool IndReportTrackingAtStart { get; set; }
        public bool IndReportTrackingAtEnd { get; set; }
        public string DefaultDestination { get; set; }
        public string DefaultRequiredScreeningLevelProcess1 { get; set; }
        public string DefaultReachedScreeningLevelProcess1 { get; set; }
        public string DefaultFailedScreeningLevelProcess1 { get; set; }
        public string DefaultRequiredScreeningLevelProcess2 { get; set; }
        public string DefaultReachedScreeningLevelProcess2 { get; set; }
        public string DefaultFailedScreeningLevelProcess2 { get; set; }
        public string DefaultRequiredScreeningLevelProcess3 { get; set; }
        public string DefaultReachedScreeningLevelProcess3 { get; set; }
        public string DefaultFailedScreeningLevelProcess3 { get; set; }
        public string DefaultRequiredScreeningLevelProcess4 { get; set; }
        public string DefaultReachedScreeningLevelProcess4 { get; set; }
        public string DefaultFailedScreeningLevelProcess4 { get; set; }
        public string BirectionalDirection { get; set; }
        public string LogisticStep { get; set; }
        public string LogisticStepId { get; set; }
        public string DefaultPhysicalClass { get; set; }
        public string AllowedDimensions { get; set; }
        public bool IndAllowOnlySecureProcess1 { get; set; }
        public bool IndAllowOnlySecureProcess2 { get; set; }
        public bool IndAllowOnlySecureProcess3 { get; set; }
        public bool IndAllowOnlySecureProcess4 { get; set; }
        public bool IndDetectMissedTrackingEvents { get; set; }
        public bool IndRoutingDefault { get; set; }
        public bool IndTransportDefault { get; set; }
        public bool LtmId { get; set; }
    }
}
