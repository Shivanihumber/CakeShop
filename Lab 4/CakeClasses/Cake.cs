namespace CakeClasses
{
	public class Cake
    {
        public const decimal STANDARD_CAKE_PRICE = 20;
        private decimal decPrice;

        public decimal Price
        {
            get
            {
                return decPrice;
            }
            set
            {
                decPrice = value;
            }
        }

        public Cake(decimal price)
        {
            decPrice = price;
        }

        public Cake()
        {
            decPrice = STANDARD_CAKE_PRICE;
        }

        public virtual double CalculateCakeCost()
        {
            return (double)Price;
        }
    }
}
