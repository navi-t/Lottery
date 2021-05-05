using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Numbers : Lottery
    {
        public Numbers(Random random) : base(random)
        {
        }

        public override int[] MakeLotteryNumbers()
        {
            var result = new int[NumberOfDigits];

            for(var i = 0; i < NumberOfDigits; i++)
            {
                result[i] = random.Next(MinVal, MaxVal);
            }

            return result;
        }
    }
}