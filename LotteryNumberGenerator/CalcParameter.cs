using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class CalcParameter
    {
        public int[] Units { get; set; } = new int[Enum.GetValues(typeof(LotteryType)).Length];
    }
}
