using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Numbers3 : Numbers
    {
        public Numbers3(Random random) : base(random)
        {
            Name = "Numbers3";
            UnitPrice = 200;
            MinVal = 0;
            MaxVal = 9;
            NumberOfDigits = 3;
        }
    }
}
