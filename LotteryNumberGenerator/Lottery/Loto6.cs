using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Loto6 : Loto
    {
        public Loto6(Random random) : base(random)
        {
            Name = "Loto6";
            UnitPrice = 200;
            MinVal = 1;
            MaxVal = 43;
            NumberOfDigits = 6;
        }
    }
}
