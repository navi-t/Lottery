using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class LotteryFactory : ILotteryFactory
    {
        public Lottery Create(LotteryType lotteryType)
        {
            switch (lotteryType)
            {
                case LotteryType.Loto6:
                    return new Loto6(new Random());
                case LotteryType.Loto7:
                    return new Loto7(new Random());
                case LotteryType.Miniloto:
                    return new Miniloto(new Random());
                case LotteryType.Numbers3:
                    return new Numbers3(new Random());
                case LotteryType.Numbers4:
                    return new Numbers4(new Random());
                default:
                    return null;
            }
        }
    }
}
