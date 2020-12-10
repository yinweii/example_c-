using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class SinhVien
    {
        private string masv;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string makhoa;
        private double diem;

        public SinhVien() { }
        public SinhVien(string masv, string hoten, DateTime ngaysinh, string gioitinh, string makhoa, double diem)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.makhoa = makhoa;
            this.diem = diem;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public double Diem { get => diem; set => diem = value; }
    }
}
