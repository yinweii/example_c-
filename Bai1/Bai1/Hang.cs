using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class Hang
    {
        private String maH;
        private String tenH;
        private int gia;
        private int sl;

        public Hang(string maH, string tenH, int gia, int sl)
        {
            this.MaH = maH;
            this.TenH = tenH;
            this.Gia = gia;
            this.Sl = sl;
        }

        public Hang()
        {
        }

        public string MaH { get => maH; set => maH = value; }
        public string TenH { get => tenH; set => tenH = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Sl { get => sl; set => sl = value; }
        public void NhapHang()
        {
            Console.WriteLine("nhap ma hang: ");
            maH = Console.ReadLine();
            Console.WriteLine("nhap ten hang: ");
            tenH = Console.ReadLine();
            Console.WriteLine("gia: ");
            gia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So luong: ");
            sl = int.Parse(Console.ReadLine());

        }
        public int Tong()
        {
            return sl * gia;
        }
        public void InHang()
        {
            Console.WriteLine("Ma:" + maH + "\t" + "Ten:" + TenH + "\t" + " gia" + gia + "\t" + " so luong: " + sl+"\t"+"Tong gia:"+ Tong());
        }
        

    }
}
