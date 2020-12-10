using System;
using System.Collections.Generic;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hang> listHang = new List<Hang>();
            int n;
            Console.WriteLine("nhap so luong hang:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i =0;i< n; i++)
            {
                Console.WriteLine("Hang thu {0} ",(i + 1));
                Hang hang = new Hang();
                hang.NhapHang();
                listHang.Add(hang);
                
            }
            Console.WriteLine("Danh sach hang vua nhap");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", (i + 1));
                listHang[i].InHang();
                Console.WriteLine("----------------------------------------");
                
            }

            Console.ReadKey();
        }
    }
}
