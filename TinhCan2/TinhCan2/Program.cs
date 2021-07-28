using System;

namespace TinhCan2
{
    class Program
    {
        static unsafe void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // để xuất ra được tiếng Việt
            Console.WriteLine("Fast inverse square root!");
            float number =2.5F;
            float x2 = number * 0.5F;
            float y = number;
            const float threehalfs = 1.5F;
            long i;
            i = *(long*) &y;
            i = 0x5f3759df - (i >> 1);
            y = *(float*) &i;
            y = y * (threehalfs - (x2 * y * y));
            y = y * (threehalfs - (x2 * y * y));
            y = 1 / y;
            Console.WriteLine($"Căn bậc 2 của {number:f5} là {y:f10}");
            //Console.ReadLine();
        }
    }
}
