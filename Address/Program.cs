using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    public class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int appartment;

        public string Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public int Appartment { get => appartment; set => appartment = value; }

        public override string ToString()
        {
            return $"{Index}, {Country}: {City}; {Street} {House}, {Appartment}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "022222",
                Country = "Ukraine",
                City = "Kiyv",
                Street = "Mayakovsky Avenue",
                House = "22",
                Appartment = 6
            };

            Console.WriteLine(address.ToString());
        }
    }
}
