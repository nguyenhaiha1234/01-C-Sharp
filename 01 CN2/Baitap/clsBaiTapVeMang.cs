using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsBaiTapVeMang
    {
        public static int[] TaoMangNgauNhien()
        {
            System.Random random = new System.Random();
            int n = random.Next(minValue: 5, maxValue: 20);
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = random.Next(minValue: 0, maxValue: 50);
            }
            A[5] = 2;
            return A;
        }
        public static void Bai122()
        {
            Console.WriteLine("Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");

            double[] A = clsXulyMang.NhapMangSoThuc();
            double max = clsXulyMang.MaxMangSoThuc(A);
            Console.WriteLine($"Phần tử có giá trị lớn nhất trong mảng là: {max}");
        }
        public static void Bai123()
        {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");

            int[] A = clsXulyMang.NhapMang();
            int vitri = clsXulyMang.ViTriMinMang(A);
            Console.WriteLine($"Vị trí có giá trị nhỏ nhất trong mảng: {vitri}");
        }
        public static void Bai124()
        {
            Console.WriteLine("Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không");

            int[] A = clsXulyMang.NhapMang();
            bool tontai = false;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < 2004 && A[i] % 2 == 0)
                {
                    tontai = true;
                    break;
                };
            }
            if (tontai)
                Console.WriteLine($"Có tồn tại số chẵn nhỏ hơn 2004");
            else
                Console.WriteLine($"Không tồn tại số chẵn nhỏ hơn 2004");
        }
        public static void Bai125()
        {
            Console.WriteLine("Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng");
            int[] A = TaoMangNgauNhien();
            //int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            int sl = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]<100 && clsXulySoNguyen.isNguyenTo(A[i])) sl++;
            }
            Console.WriteLine($"Có {sl} số nguyên tố nhỏ hơn 100 trong mảng");

        }

        public static void SapxepMang()
        {
            Console.WriteLine("Mảng ban đầu");
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            //int[] A = clsXulyMang.NhapMang();
            A = clsXulyMang.SapXepMangTangdan(A);
            Console.WriteLine("Mảng sau khi sắp xếp");
            clsXulyMang.XuatMang(A);
        }
        public static void Bai140()
        {
            static double DuongNhoNhat(double[] A)
            {
                double linhcanh = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > 0)
                    {
                        if (A[i] < linhcanh || linhcanh == -1) linhcanh = A[i];
                    }
                }
                return linhcanh;
            }
            Console.WriteLine("Bài 140: Hãy tìm giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì sẽ trả về -1");
            //int[] A = TaoMangNgauNhien();
            double[] A = clsXulyMang.NhapMangSoThuc();
            //clsXulyMang.XuatMang(A);
            Console.WriteLine($"{DuongNhoNhat(A)}");

        }

        public static void Bai151()
        {
            static double TimNguyenToLonNhat(int[] A)
            {
                int linhcanh = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > linhcanh)
                        if (clsXulySoNguyen.isNguyenTo(A[i]))
                            linhcanh = A[i];
                }
                return linhcanh;
            }
            Console.WriteLine("Bài 151: Hãy tìm số nguyên tố lớn nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về -1");
            int[] A = TaoMangNgauNhien();
            //int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            Console.WriteLine($"{TimNguyenToLonNhat(A)}");

        }
    }
}
