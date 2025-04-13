using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Animali
    {
        private string _name;
        private string _breed;
        private string _DateOFDR;
        private double _weight;


        public virtual string Info() => $"Имя: {_name}, порода: {_breed}, вес: {_weight}, дата рождения: {_DateOFDR}";

        public Animali(string name, string breed, string birthDate, double weight)
        {
            _name = name;
            _breed = breed;
            _DateOFDR = birthDate;
            _weight = weight;
        }
    }
}