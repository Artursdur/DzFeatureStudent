﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MethodCinema
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;
        private string _cinemaHall;

        public void SetMovieName(string movieName) => movieName = _movieName;
        public string GetMovieName() => _movieName;

        public double GetPrice() => _price;

        public string GetCinemaHall() => _cinemaHall;

        public string Info() => $"Название фильма: {_movieName}, цена билета: {_price}, вместимось: {_peopleCapacity}, кинозал: {_cinemaHall}";


        public MethodCinema(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            _cinemaHall = cinemaHall;
        }
    }
}