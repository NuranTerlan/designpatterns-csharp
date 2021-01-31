namespace DesignPatterns.FacetedB
{
    public class Car
    {
        // General info
        public CarBrands Brand { get; set; }
        public string Model { get; set; }
        public int CreationYear { get; set; }
        public double DistanceWithKm { get; set; }

        // About engine and it's features
        public double Engine { get; set; }
        public int HorsePower { get; set; }
        public int Torque { get; set; }

        // Trade info
        public decimal Price { get; set; }
        public bool IsSecondHand { get; set; }

        // Address info
        public string InCity { get; set; }
        public string InDealer { get; set; }

        public override string ToString()
        {
            return $"\n--------------\n" +
                   $"{Brand} {Model} | {CreationYear} | ${Price}\n" +
                   $"Engine Info: {Engine}, {HorsePower}Hp, {Torque}Nm\n" +
                   $"Roadage: {DistanceWithKm}km\n" +
                   $"Usage Status: {(IsSecondHand ? "Second Hand" : "New")}\n" +
                   $"Address: {InDealer}, {InCity}" +
                   $"\n--------------\n";
        }
    }
}