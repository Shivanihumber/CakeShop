using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Customer
    {
        private string strFirstName;
        private string strLastName;
        private Address address;
        private List<string> mailings;

        public List<string> Mailings
        {
            get { return mailings; }
            set { mailings = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public string FirstName
        {
            get
            {
                return strFirstName;
            }
            set
            {
                strFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return strLastName;
            }
            set
            {
                strLastName = value;
            }
        }

        public Customer()
        {
            Mailings = new List<string>();
        }
        public Customer(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            Mailings = new List<string>();
        }

        public override String ToString()
        {
            string strMessage = "Thank you " + FirstName + " " + LastName + "!! " + Environment.NewLine + Address.ToString() + Environment.NewLine;
          if (Mailings.Count > 0)
            {
                strMessage += Environment.NewLine + "Mailings: ";
            }
            for (int i = 0; i < Mailings.Count; i++)
            {
                //add mailings into string, but don't
                //put a comma after the last one
                if (i < Mailings.Count - 1)
                {
                    strMessage += Mailings[i] + ", ";
                }
                else
                {
                    strMessage += Mailings[i];
                }
            }
            return strMessage;
        }
        }
}
