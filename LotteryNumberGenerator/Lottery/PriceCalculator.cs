using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class PriceCalculator
    {
        public static int CalcPrice(CalcParameter param)
        {
            var result = 0;

            for(var i = 0; i < param.Units.Length; i++)
            {
                var lotteryType = (LotteryType)Enum.ToObject(typeof(LotteryType), i);
                var factory = new LotteryFactory();
                var targetLottery = factory.Create(lotteryType);
                result += targetLottery.CalcTotalPrice(param.Units[i]);
            }

            return result;
        }
    }
}
