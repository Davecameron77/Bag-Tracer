using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Models a PD3 Dimension
    /// </summary>
    class Pd3Dimension
    {
        [Key]
        public int EFId { get; set; }
        public string Pd3Width { get; set; }
        public string Pd3Height { get; set; }
    }
}
