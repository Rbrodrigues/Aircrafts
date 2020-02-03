using System.ComponentModel.DataAnnotations;

namespace Konatus.ABCD_Airlines.Web.Models
{
    public class ViewmodelModeloAeronave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string Code { get; set; }
        [StringLength(4)]
        public string AlternativeCode { get; set; }
        [Required]
        //[RegularExpression(@"^\d+\.\d{0,3}$")]
        public decimal MaxDepartureWeight { get; set; }
        [Required]
        //[RegularExpression(@"^\d+\.\d{0,3}$")]
        public decimal MaxLandingWeight { get; set; }
    }
}