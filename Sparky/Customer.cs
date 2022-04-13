using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public int Discount { get; set; }

        public int OrderTotal { get; set; }

        public string GreetMessage { get; set; }

        public bool IsPlatinum { get; set; }

        public Customer()
        {
            Discount = 15;
            IsPlatinum = false;
        }


        public string GreetAndCombineNames(string firstName, string LastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty First Name");
            } 

            GreetMessage = $"Hello, {firstName} {LastName}";
            Discount = 20;
            return GreetMessage;
        }
    }
}
