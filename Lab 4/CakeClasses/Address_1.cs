using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public Address(string street, string city, string pro, string pCode)
        {
            Street = street;
            City = city;
            Province = pro;
            PostalCode = pCode;
        }

        public override string ToString()
        {
            return Street + ", " + City + ", " + Province + " " + PostalCode;
        }
    }
}
