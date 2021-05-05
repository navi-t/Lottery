using System;
using System.Collections.Generic;

namespace LotteryNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowInputRequestMessage();
                MainProcess();
            }
        }

        static void ShowInputRequestMessage()
        {
            Console.WriteLine("★Please select a lottery type.");
            var lotteryTypeSelectionDialog = new List<string>();
            foreach (var typeEnumValue in Enum.GetValues(typeof(LotteryType)))
            {
                var message = $"{Enum.GetName(typeof(LotteryType), typeEnumValue)}:{(int)typeEnumValue}";
                lotteryTypeSelectionDialog.Add(message);
            }
            Console.WriteLine(string.Join(", ", lotteryTypeSelectionDialog));
        }

        static void MainProcess()
        {
            if (!int.TryParse(Console.ReadLine(), out int input) || input >= Enum.GetValues(typeof(LotteryType)).Length)
            {
                Console.WriteLine("[Error] Illegal inputs. Please try again." + Environment.NewLine);
            }
            else
            {
                LotteryType lotteryType = (LotteryType)input;

                var lotteryNumber = LotteryNumberGenerator.MakeLotteryNumbers(lotteryType);

                Console.WriteLine("Lottery Number:" + string.Join(", ", lotteryNumber) + Environment.NewLine);
            }
        }
    }
}
