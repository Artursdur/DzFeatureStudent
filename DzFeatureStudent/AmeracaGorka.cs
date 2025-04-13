using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class AmeracaGorka : Actractoniossadsad
    {
        private double _price;

        public override double GetRevenue(int people = 0)
        {
            return base.GetRevenue();
        }

        public override string Info()
        {
            return base.Info();
        }

        public AmeracaGorka(double price, string name, double duration, int maxSeats)
            : base(name, duration, maxSeats, price)
        {
            _price = price;
        }
    }
}