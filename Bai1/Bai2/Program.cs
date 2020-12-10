using System;
using System.Collections.Generic;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            int n;
            Console.WriteLine("nhap so Sinh Vien:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sv thu {0} ", (i + 1));
               SinhVien sv = new SinhVien();
                sv.nhapSv();
                listSinhVien.Add(sv);


            }
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if( listSinhVien[i].DiemTb < listSinhVien[j].DiemTb)
                    {
                        SinhVien tmp = listSinhVien[i];
                        listSinhVien[i] = listSinhVien[j];
                        listSinhVien[j] = tmp;
                    }
                }

            }
            Console.WriteLine("Danh sach Sv ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", (i + 1));
                listSinhVien[i].InSv();
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("Danh 3 Sinh Vien co diem cao nhat ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", (i + 1));
                listSinhVien[i].InSv();
                
            }
            Console.ReadKey();
        }
    }
}
