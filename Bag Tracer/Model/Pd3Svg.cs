using System.ComponentModel.DataAnnotations;

namespace Bag_Tracer.Model
{
    /// <summary>
    /// Models a PD3 SVG
    /// </summary>
    class Pd3Svg
    {
        [Key]
        public int EFId { get; set; }
        public string ElementId { get; set; }
        public string Path { get; set; }
    }
}
