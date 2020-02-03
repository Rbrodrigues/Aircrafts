namespace Konatus.ABCD_Airlines.Core.Entity
{
    public class ModeloAeronave
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AlternativeCode { get; set; }
        public decimal MaxDepartureWeight { get; set; }
        public decimal MaxLandingWeight { get; set; }
    }
}
