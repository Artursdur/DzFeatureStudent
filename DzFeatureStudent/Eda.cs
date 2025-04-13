using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Eda : CafeCHTOTOTAM
    {

        private double _calories;
        private double _weight;

        public override string GetDishPrice()
        {
            return base.GetDishPrice();
        }

        public override string Info()
        {
            return base.Info();
        }

        public Eda(double calories, double weight, string dishName, double price, string category)
            : base(dishName, price, category, weight)
        {
            _calories = calories;
            _weight = weight;
        }
    }
}