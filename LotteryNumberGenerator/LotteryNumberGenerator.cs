using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class LotteryNumberGenerator
    {
        public static int[] MakeLotteryNumbers(LotteryType lotteryType)
        {
            var factory = new LotteryFactory();
            return factory.Create(lotteryType).MakeLotteryNumbers();
        }

        public static IDictionary<string, List<int[]>> MakeLotteryNumbers(CalcParameter param)
        {
            var result = new Dictionary<string, List<int[]>>();

            for(var i = 0; i < param.Units.Length; i++)
            {
                var lotteryName = Enum.GetName(typeof(LotteryType), i);
                var lotteryNumbers = new List<int[]>();
                for(var j = 0; j < param.Units[i]; j++)
                {
                    lotteryNumbers.Add(MakeLotteryNumbers((LotteryType)Enum.ToObject(typeof(LotteryType), i)));
                }
                result[lotteryName] = lotteryNumbers;
            }

            return result;
        }
    }
}
