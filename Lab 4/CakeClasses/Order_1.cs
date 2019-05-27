using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Order
    {
        public const decimal TAX = 0.13m;
        private int intNumOfCakes;
        private Customer customer;
        private Cake cake;
        //confirmation number for order
        //generated when order accepted
        private int confirmationNumber;
        //generate random number
        Random rndClass = new Random();
        private List<Cake> cakeList;

        public Customer Customer
        {
            get{ return customer;}
            set{ customer = value;}
        }

        public Cake Cake { get; set; }
        public int NumOfCakes
        {
            get
            {
                return intNumOfCakes;
            }
            set
            {
                intNumOfCakes = value;
            }
        }
        public List<Cake> CakeList
        {
            get { return cakeList; }
            set { cakeList = value; }
        }

        //no set needed for confirmation number, it's generated here
        public int ConfirmationNumber
        {
            get
            {
                return //randomize number between 10000 and 100000
                confirmationNumber = rndClass.Next(10000, 100000);
            }
        }

        //wrote for Lab 3 so it initialises cake list
        public Order()
        {
            CakeList = new List<Cake>();
            Customer = new Customer();
        }

        public Order(Customer customer, int numOfCakes)
        {
            Customer = customer;
            NumOfCakes = numOfCakes;
        }

        public Order(string fName, string lName, int numOfCakes)
        {
            Customer = new Customer(fName, lName);
            NumOfCakes = numOfCakes;
        }

        //for Custom cake
        public void AddCake(string flavour, string occ, int layers)
        {
            CakeList.Add(new CustomCake(flavour, occ, layers));
        }
        //for Traditional cake
        public void AddCake(string name)
        {
            CakeList.Add(new TraditionalCake(name));
        }

        public void ClearCakeList()
        {
            CakeList.Clear();
        }
       
        public decimal CalculateCost()
        {
            decimal total = 0;
            foreach(Cake cake in CakeList)
            {
                total += (decimal)cake.CalculateCakeCost();
            }
            
            return total * (1 + TAX);
        }

        public override string ToString()
        {
            string output = "";
            output += customer.ToString() + "!!\nYou have ordered " + cakeList.Count + " cake \n";
                foreach(Cake cake in CakeList){
                    output += cake.ToString() + "\n";
                }
            output += " for the total cost of " + CalculateCost().ToString("c");
            return output;
        }

        public string PrintConfirmation()
        {
            //confirmation number to string method
            return Customer.ToString() + "!! Your order has been placed."
                + Environment.NewLine + "Your Confirmation Code is : " + ConfirmationNumber;
        }
    }
}
