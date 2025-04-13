using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Actractoniossadsad
    {
        private string _name;
        private double _time;
        private int _maxSeats;
        private double _price;

        public virtual string Info() => $"Название: {_name}, продолжительность поездки: {_time}, максимальное кол-во мест: {_maxSeats}";

        public virtual double GetRevenue(int people = 0)
        {
            if (people == 0)
            {
                return _price * _maxSeats;
            }
            else
            {
                return people * _price;
            }
        }

        public Actractoniossadsad(string name, double duration, int maxSeats, double price)
        {
            _name = name;
            _time = duration;
            _maxSeats = maxSeats;
            _price = price;
        }
    }
}          //че так сложно то *