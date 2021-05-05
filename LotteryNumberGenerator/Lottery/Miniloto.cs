using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Miniloto : Loto
    {
        public Miniloto(Random random) : base(random)
        {
            Name = "Miniloto";
            UnitPrice = 200;
            MinVal = 1;
            MaxVal = 31;
            NumberOfDigits = 5;
        }
    }
}
