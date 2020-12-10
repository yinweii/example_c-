using System;
using System.Collections.Generic;
using System.Text;

namespace TamGiac
{
    class TamGiac
    {
        private float a;
        private float b;
        private float c;

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public TamGiac(float a, float b, float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public TamGiac()
        {
        }

        public void Nhap()
        {
            Console.WriteLine(" nhap canh a:");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine(" nhap canh b:");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine(" nhap canh c:");
            C = float.Parse(Console.ReadLine());
        }
        public bool check()
        {
            if (a + b > c || a + c > b || b+c > a)
            {
                return true;
            }
            return false;
        }
        public float chuVi()
        {
            return (float)(a + b + c);
        }

        public float DienTich()
        {
            float p = (float)((float) chuVi() / 2.0);
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public void loaiTamGiac()
        {
            if(check())
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    Console.WriteLine(" Tam giac vuong");
                }
                else if (a == b || a ==c || b ==c) 
                {
                    Console.WriteLine(" Tam giac can");
                }
                else if(a == b && a==c)
                {
                    Console.WriteLine(" Tam giac deu");
                }
                else
                {
                    Console.WriteLine(" Tam giac thuong");
                }

            }
            
            
        }

        


    }
}
