using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");

        }
    }
    class Restaurant
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Type { get; set; }
        private double Rating { get; set; }

        public Restaurant(int ID,string Name,string Type,double Rating)
        {
            this .ID = ID;
            this .Name = Name;
            this .Type = Type;
            this .Rating = Rating;
        }
    }
}
