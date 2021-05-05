using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Loto7 : Loto
    {
        public Loto7(Random random) : base(random)
        {
            Name = "Loto7";
            UnitPrice = 300;
            MinVal = 1;
            MaxVal = 37;
            NumberOfDigits = 7;
        }
    }
}
