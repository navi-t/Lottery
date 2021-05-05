using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Lottery
    {
        protected Random random;

        public Lottery(Random random)
        {
            this.random = random;
        }

        public string Name { get; protected set; }
        public int UnitPrice { get; protected set; }
        public int MinVal { get; protected set; }
        public int MaxVal { get; protected set; }
        public int NumberOfDigits { get; protected set; }

        public virtual int[] MakeLotteryNumbers()
        {
            return null;
        }

        public int CalcTotalPrice(int units)
        {
            return UnitPrice * units;
        }
    }
}
