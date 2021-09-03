using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsXulySoNguyen
    {
        public static bool isNguyenTo(int N)
        {
            if (N <= 1) return false;
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0) return false;
            }
            return true;
        }
    }
}
