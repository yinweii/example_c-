using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tg = new TamGiac();
            tg.Nhap();
            if( tg.check())
            {
                Console.WriteLine("Chu vi cua tam giac la: {0} ",tg.chuVi());
                Console.WriteLine("Dien tich cua tam giac la: {0} ", tg.DienTich());
                tg.loaiTamGiac();
             
            }
            else
            {
                Console.WriteLine("Hello World!");
            }

            Console.ReadKey();

           // Console.WriteLine("Hello World!");
        }
    }
}
