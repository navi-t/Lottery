using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryNumberGenerator;

namespace Lottery3_WinForms
{
    public class UIParameter
    {
        public int[] Units { get; set; } = new int[Enum.GetValues(typeof(LotteryType)).Length];
    }
}
