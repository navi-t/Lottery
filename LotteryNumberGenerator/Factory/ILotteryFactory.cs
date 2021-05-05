using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    interface ILotteryFactory
    {
        public Lottery Create(LotteryType type);
    }
}
