using System.ComponentModel.DataAnnotations;

namespace Konatus.ABCD_Airlines.Web.Models
{
    public class ViewmodelAeronave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(6)]
        public string Prefix { get; set; }
        [Required]
        //[RegularExpression(@"^\d+\.\d{0,3}$")]
        public decimal MaxDepartureWeight { get; set; }
        [Required]
        //[RegularExpression(@"^\d+\.\d{0,3}$")]
        public decimal MaxLandingWeight { get; set; }
        
        public bool Active { get; set; }

        public string AircraftModel { get; set; }

        public int AircraftModelId { get; set; }

        public virtual ViewmodelModeloAeronave Modelo { get; set; }
    }
}