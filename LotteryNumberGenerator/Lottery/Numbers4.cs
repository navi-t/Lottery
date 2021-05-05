using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Numbers4 : Numbers
    {
        public Numbers4(Random random) : base(random)
        {
            Name = "Numbers4";
            UnitPrice = 200;
            MinVal = 0;
            MaxVal = 9;
            NumberOfDigits = 4;
        }
    }
}
