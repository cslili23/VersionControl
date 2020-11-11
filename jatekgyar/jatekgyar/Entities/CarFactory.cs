using jatekgyar.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatekgyar.Entities
{
    class CarFactory :IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
