namespace CakeClasses
{
	public class TraditionalCake : Cake
    {
        private const decimal STRAWBERRYCHEESE = 22m;
        private const decimal LEMONVELVET = 25m;
        private const decimal TIRAMISU = 30m;
        private const decimal BLUEBERRYMOUSSE = 20m;
        private string[] traditionalCakes = { "Strawberry Cheese Cake", "Lemon Velvet Cake", "Blueberry Mousse", "Tiramisu" };
        private decimal[] prices = { STRAWBERRYCHEESE, LEMONVELVET, BLUEBERRYMOUSSE, TIRAMISU };

        public string Name { get; set; }

        public TraditionalCake(string name)
            : base()
        {
            Name = name;
            for (int i = 0; i < traditionalCakes.Length; i++)
            {
                if (Name == traditionalCakes[i])
                {
                    Price = prices[i];
                }
            }
        }

        public override double CalculateCakeCost()
        {
            return (double)Price;
        }
        public override string ToString()
        {
            return Name + " at price $" + CalculateCakeCost();
        }
    }
}
