using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class Loto : Lottery
    {
        public Loto(Random random) : base(random)
        {
        }

        public override int[] MakeLotteryNumbers()
        {
            var numbers = new List<int>();

            do
            {
                var newNumber = random.Next(MinVal, MaxVal);
                if (!numbers.Contains(newNumber))
                {
                    numbers.Add(newNumber);
                }
            } while (numbers.Count < NumberOfDigits);

            var result = numbers.Distinct().ToList();
            result.Sort();

            return result.ToArray();
        }
    }
}
