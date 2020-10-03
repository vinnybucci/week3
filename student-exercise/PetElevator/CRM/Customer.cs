using PetElevator.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator
{
    public class Customer : Person, IBillable 
    {

        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }
        public Customer(string firstName, string lastName) : this(firstName, lastName, "") 
        {

        }

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            
                double price = 0;
            if (!(servicesRendered == null))
            {
                foreach (KeyValuePair<string, double> value in servicesRendered)
                {
                    price += value.Value;

                }
            }
                return price;
            
        }
    }
}
