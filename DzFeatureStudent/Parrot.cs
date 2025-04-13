using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Parrot : Animali
    {
        public override string Info() => $"{base.Info()}";


        public Parrot(string name, string breed, string birthDate, double weight)
            : base(name, breed, birthDate, weight)
        {

        }
    }
}