using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryNumberGenerator;

namespace Lottery3_WinForms
{
    public class Controller
    {
        private ParameterManager paramManager = new ParameterManager();

        public UIParameter Parameter
        {
            get
            {
                return paramManager.GetUIParameter();
            }
            set
            {
                paramManager.SetUIParameter(value);
            }
        }

        public string Execute()
        {
            var calcParam = paramManager.GetCalcParameter();
            var lotteryNumbers = LotteryNumberGenerator.LotteryNumberGenerator.MakeLotteryNumbers(calcParam);
            var totalPrice = PriceCalculator.CalcPrice(calcParam);

            return GenerateResultMessage(lotteryNumbers, totalPrice);
        }

        public int CalcPrice()
        {
            var calcParam = paramManager.GetCalcParameter();
            return PriceCalculator.CalcPrice(calcParam);
        }

        private string GenerateResultMessage(IDictionary<string, List<int[]>> dict, int price)
        {
            var result = string.Empty;
            var sb = new StringBuilder();

            if(price <= 0)
            {
                return "## Invalid Inputs !! ##";
            }

            sb.Append($"★Purchase cost：{price.ToString("C")}");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append("★Lottery Numbers:" + Environment.NewLine);
            foreach (var item in dict)
            {
                sb.Append($"<{item.Key}>" + Environment.NewLine);
                foreach(var number in item.Value)
                {
                    sb.Append(string.Join(", ", number));
                    sb.Append(Environment.NewLine);
                }
                sb.Append(Environment.NewLine);
            }

            result = sb.ToString();
            return result;
        }
    }
}
