using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bai2
{
    class SinhVien
    {
        private String maSv;
        private String tenSv;
        private int diemTb;

        public SinhVien(string maSv, string tenSv, int diemTb)
        {
            this.MaSv = maSv;
            this.TenSv = tenSv;
            this.DiemTb = diemTb;
        }

        public SinhVien()
        {
        }

        public string MaSv { get => maSv; set => maSv = value; }
        public string TenSv { get => tenSv; set => tenSv = value; }
        public int DiemTb { get => diemTb; set => diemTb = value; }
        public void nhapSv()
        {
            Console.WriteLine("Ma Sv: ");
            maSv = Console.ReadLine();
            Console.WriteLine("ten ten: ");
            tenSv = Console.ReadLine();
            Console.WriteLine("diem Tb: ");
            diemTb = Convert.ToInt32(Console.ReadLine());
        }
        public void InSv()
        {
            Console.WriteLine("MaSv:" + maSv + "\t" + "TenSv:" + tenSv + "\t" + "diem TB: " + diemTb );
        }

    }
}
