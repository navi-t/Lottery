using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryNumberGenerator;

namespace Lottery3_WinForms
{
    public class ParameterManager
    {
        private int[] units = new int[Enum.GetValues(typeof(LotteryType)).Length];

        public void SetUIParameter(UIParameter param)
        {
            this.units = param.Units;
        }

        public UIParameter GetUIParameter()
        {
            var result = new UIParameter();

            result.Units = this.units;

            return result;
        }

        public CalcParameter GetCalcParameter()
        {
            var result = new CalcParameter();

            result.Units = this.units;

            return result;
        }
    }
}
