using System;
using System.Collections.Generic;

namespace Bai3Qlsv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> ListSinhVien = new List<SinhVien>();
            int n;
            Console.Write("Nhap so SV: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Error! So SV phai lon hon 0!");
                    Console.Write("Nhap lai so SV:");
                }
                else break;
            } while (n > 0);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", (i + 1));
                SinhVien sv = new SinhVien();
                sv.NhapTT();
                ListSinhVien.Add(sv);
                Console.WriteLine("--------------------------------------");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin sinh vien thu {0}", (i + 1));
                ListSinhVien[i].XuatTT();
                Console.WriteLine("--------------------------------------");

            }
            Console.WriteLine("Sinh vien co diem trung binh lon hon 5");
            for (int i = 0; i < n; i++)
            {
                if(ListSinhVien[i].DiemTB() > 5.0)
                {
                    ListSinhVien[i].XuatTT();
                }
            }
            Console.ReadKey();
        }
    }
}
