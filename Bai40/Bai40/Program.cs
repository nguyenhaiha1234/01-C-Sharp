using System;

namespace Bai40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // để xuất ra được tiếng Việt
            Console.WriteLine("Bài 40");
            Console.Write("Nhập vào số thực x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên N: ");
            int N = int.Parse(Console.ReadLine());
            int i;
            double S = Math.Sqrt(x);
            double X = x; // mỗi vòng lặp ta tính X lũy thừa i
            for (i=2; i<=N; i++)
            {
                X *= x; // với i = 2 thì X = x^2; i =3 thì X = x^3... abc
                S = Math.Sqrt(X + S);           
            }
            Console.WriteLine($"Kết quả S là: {S:f5}"); //ta muốn viết kết quả ra là số thực có 5 số thập phân

        }
    }
}
