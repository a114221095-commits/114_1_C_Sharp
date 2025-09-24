using System;

namespace ConsoleApp1_0924
{
    internal class Program
    {
        enum TrainType
        {
            自強號 = 1,
            莒光號 = 2,
            復興號 = 3
        }

        static void Main(string[] args)
        {
            Console.Write("請輸入行駛公里數：");
            if (!double.TryParse(Console.ReadLine(), out double km) || km <= 0)
            {
                Console.WriteLine("公里數輸入錯誤！");
                return;
            }

            Console.WriteLine("請選擇車型：1.自強號 2.莒光號 3.復興號");
            if (!int.TryParse(Console.ReadLine(), out int typeInput) || typeInput < 1 || typeInput > 3)
            {
                Console.WriteLine("車型輸入錯誤！");
                return;
            }
            TrainType trainType = (TrainType)typeInput;

            double pricePerKm = 0;
            switch (trainType)
            {
                case TrainType.自強號:
                    pricePerKm = 2.27;
                    break;
                case TrainType.莒光號:
                    pricePerKm = 1.75;
                    break;
                case TrainType.復興號:
                    pricePerKm = 1.46;
                    break;
            }

            double price = km * pricePerKm;

            Console.Write("是否優待票？(y/n)：");
            string halfTicket = Console.ReadLine();
            if (halfTicket.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                price /= 2;
            }

            Console.Write("是否為去回票？(y/n)：");
            string roundTrip = Console.ReadLine();
            if (roundTrip.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                price = price * 2 * 0.9;
            }

            Console.WriteLine($"票價為：{Math.Round(price, 0)} 元");
        }
    }
}
