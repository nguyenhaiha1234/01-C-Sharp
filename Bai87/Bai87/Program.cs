using System;

namespace Bai87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // để xuất ra được tiếng Việt
            Console.WriteLine("Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + … + n > 10000");
            int n = 0;
            int S = 0;
            while (S <= 10)
            {
                n++;
                S += n;
            }
            Console.WriteLine($"Số n nhỏ nhất thỏa điều kiện là: {n}");
        }
    }

}

