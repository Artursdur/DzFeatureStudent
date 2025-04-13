using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cat : Animali
    {

        public bool CatchMouse(int num)
        {
            if (num <= 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string Info() => $"{base.Info()}, котик поймал мышку? Ответ -> {CatchMouse(100)}";

        public Cat(string name, string breed, string birthDate, double weight)
            : base(name, breed, birthDate, weight)
        {

        }
    }
}