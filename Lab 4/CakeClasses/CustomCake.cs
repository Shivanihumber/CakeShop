namespace CakeClasses
{
	public class CustomCake : Cake
    {
        private const int LAYERPRICE = 3;

        public string Occasion { get; set; }
        public int Layers { get; set; }
        public string Flavour { get; set; }

        public CustomCake(string flavour, string occ, int layers)
            : base()
        {
            Flavour = flavour;
            Occasion = occ;
            Layers = layers;
        }

        public override double CalculateCakeCost()
        {
            return (base.CalculateCakeCost() + (Layers * LAYERPRICE));
        }

        public override string ToString()
        {
            return " " + Occasion + " cake, " + Flavour + " flavoured with " + Layers + " tier(s) ";
        }
    }
}
