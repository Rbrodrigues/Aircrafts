namespace Konatus.ABCD_Airlines.Core.Entity
{
    public class Aeronave
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public decimal MaxDepartureWeight { get; set; }
        public decimal MaxLandingWeight { get; set; }
        public bool Active { get; set; }
        public string AircraftModel { get; set; }
        public int AircraftModelId { get; set; }
        public virtual ModeloAeronave Modelo { get; set; }

    }
}
