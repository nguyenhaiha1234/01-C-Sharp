using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap {
    class clsBaiTapVeMang {
        public static int[] TaoMangNgauNhien() {
            System.Random random = new System.Random();
            int n = random.Next(minValue: 5, maxValue: 50);
            int[] A = new int[n];
            for (int i = 0; i < n; i++) {
                A[i] = random.Next(minValue: 30, maxValue: 50);
            }
            A[5] = 2;
            return A;
        }
        public static void Bai122() {
            Console.WriteLine("Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");

            double[] A = clsXulyMang.NhapMangSoThuc();
            double max = clsXulyMang.MaxMangSoThuc(A);
            Console.WriteLine($"Phần tử có giá trị lớn nhất trong mảng là: {max}");
        }
        public static void Bai123() {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");

            int[] A = clsXulyMang.NhapMang();
            int vitri = clsXulyMang.ViTriMinMang(A);
            Console.WriteLine($"Vị trí có giá trị nhỏ nhất trong mảng: {vitri}");
        }
        public static void Bai124() {
            Console.WriteLine("Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không");

            int[] A = clsXulyMang.NhapMang();
            bool tontai = false;
            for (int i = 1; i < A.Length; i++) {
                if (A[i] < 2004 && A[i] % 2 == 0) {
                    tontai = true;
                    break;
                };
            }
            if (tontai)
                Console.WriteLine($"Có tồn tại số chẵn nhỏ hơn 2004");
            else
                Console.WriteLine($"Không tồn tại số chẵn nhỏ hơn 2004");
        }
        public static void Bai125() {
            Console.WriteLine("Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng");
            int[] A = TaoMangNgauNhien();
            //int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            int sl = 0;
            for (int i = 0; i < A.Length; i++) {
                if (A[i] < 100 && clsXulySoNguyen.isNguyenTo(A[i])) sl++;
            }
            Console.WriteLine($"Có {sl} số nguyên tố nhỏ hơn 100 trong mảng");

        }

        public static void SapxepMang() {
            Console.WriteLine("Mảng ban đầu");
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            //int[] A = clsXulyMang.NhapMang();
            A = clsXulyMang.SapXepMangTangdan(A);
            Console.WriteLine("Mảng sau khi sắp xếp");
            clsXulyMang.XuatMang(A);
        }
        public static void Bai140() {
            static double DuongNhoNhat(double[] A) {
                double linhcanh = -1;
                for (int i = 0; i < A.Length; i++) {
                    if (A[i] > 0) {
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

        public static void Bai151() {
            static double TimNguyenToLonNhat(int[] A) {
                int linhcanh = -1;
                for (int i = 0; i < A.Length; i++) {
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

        public static void Bai155() {
            static int TimSoXaNhat(int[] A, int x) {
                int Maxindex = 0;
                int index = 0;
                for (int i = 0; i < A.Length; i++) {
                    if (Math.Abs(A[i] - x) > Maxindex) {
                        Maxindex = Math.Abs(A[i] - x);
                        index = i;
                    }
                }
                return index;
            }

            Console.WriteLine("Bài 155: Hãy tìm giá trị trong mảng các số thực xa giá trị x nhất");
            int[] A = TaoMangNgauNhien();
            //int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            Console.Write("Nhập giá trị x: ");
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine($"Số xa X nhất là {A[TimSoXaNhat(A, x)]}");

        }

        public static void Bai160() {
            static bool isSoGanh(int x) {
                int soDao = 0;
                int soBandau = x;
                while (x > 0) {
                    int k = x % 10;
                    soDao = soDao * 10 + k;
                    x = x / 10;
                }
                return soDao == soBandau;
            }
            Console.WriteLine("Cho mảng 1 chiều các số nguyên. Hãy tìm giá trị đầu tiên thỏa mãn tính chất số gánh");
            int[] A = clsXulyMang.NhapMang();
            //int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);


            for (int i = 0; i < A.Length; i++) {
                if (isSoGanh(A[i])) Console.WriteLine(A[i]);
            }
        }

        public static void Bai173() {
            int[] KhongDenChin = new int[10];
            void Demso(int x) {
                while (x > 0) {
                    int k = x % 10;
                    KhongDenChin[k]++;
                    x = x / 10;
                }
            }
            Console.WriteLine("Cho mảng 1 chiều các số nguyên. Hãy  viết hàm tìm chữ số xuất hiện ít nhất trong mảng");
            int[] A = clsXulyMang.NhapMang();
            //int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);

            for (int i = 0; i < A.Length; i++) {
                Demso(A[i]);
            }
            int min = KhongDenChin[0];
            int index = 0;
            for (int i = 1; i < 10; i++) {
                if (KhongDenChin[i] > 0)
                    if (KhongDenChin[i] < min || min == 0) {
                        min = KhongDenChin[i];
                        index = i;
                    }
            }
            Console.WriteLine($"Chữ số xuất hiện ít nhất là {index}. Xuất hiện { KhongDenChin[index]} lần");
        }

        public static void Bai174() {
            Console.WriteLine("Cho mảng số thực có nhiều hơn 2 giá trị và các giá trị trong mảng khác nhau từng đôi một. Hãy viết hàm liệt kê tất cả các cặp giá trị (a, b) trong mảng thỏa điều kiện a <= b");
            int[] A = clsXulyMang.NhapMang();
            //int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);

            for (int i = 0; i < A.Length; i++) {
                for (int j = i + 1; j < A.Length; j++) {
                    if (A[i] < A[j])
                        Console.WriteLine($"{A[i]} < {A[j]} ");
                    else
                        Console.WriteLine($"{A[j]} < {A[i]} ");
                }
            }


        }

        public static void Bai230() {
            Console.WriteLine("Bài 230: Liệt kê tần suất xuất hiện các giá trị trong mảng (mỗi giá trị liệt kê 1 lần)");
            //int[] A = clsXulyMang.NhapMang();
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);

            int[] dem = new int[A.Length];
            for (int i = 0; i < A.Length; i++) {
                dem[i] = 0;
                if (A[i] != -1) {
                    dem[i] = 1;
                    for (int j = i + 1; j < A.Length; j++) {
                        if (A[i] == A[j]) {
                            dem[i]++;
                            A[j] = -1;
                        }
                    }
                }
            }
            for (int i = 0; i < A.Length; i++) {
                if (dem[i] > 0)
                    Console.WriteLine($"Phần tử  {A[i]} xuất hiện {dem[i]} lần");
            }

        }
        public static void BaiTest() {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
        }

    }
}
