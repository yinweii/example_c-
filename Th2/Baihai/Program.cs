using System;

namespace Baihai
{
    class Program
    {
        int So_Hang, So_Cot;
        int[,] arr = new int[50,50];

        public void NhapMang()
        {
            Console.Write("Nhap so hang cua ma tran: ");
            So_Hang = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran: ");
            So_Cot = int.Parse(Console.ReadLine());
            for (int i = 1; i <= So_Hang; i++)
                for (int j = 1; j <= So_Cot; j++)
                {
                    Console.Write("Nhap phan tu thu a[" + i + "," + j + "]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void InMatTran()
        {
            Console.WriteLine("\t Ma tran: \n");
            for (int i =1; i <= So_Hang; i++)
            {
                for (int j = 1; j <= So_Cot; j++)
                {
                    Console.Write("\t" + arr[i, j] + " ");
                }
                Console.WriteLine();
               
            }
        }

        public void TongDong()
        {
            int S;
            for (int i = 1; i <= So_Hang; i++)
            {
                S = 0;
                for (int j = 1; j <= So_Cot; j++)
                {
                    S += arr[i,j];
                }
                Console.WriteLine("tong hang " + i + ":" + S);
                

               
            }
        }
        public void TongCot()
        {
            Console.WriteLine("-----------------------------");
            int S;
            for (int i = 1; i <= So_Cot; i++)
            {
                S = 0;
                for (int j = 1; j <= So_Hang; j++)
                {
                    S += arr[j, i];
                }
                Console.WriteLine("tong Cot " + i + ":" + S);

            }
        }
        public void TongDuongCheo()
        {
            Console.WriteLine("-----------------------------");
            int S;
            for (int i = 1; i <= So_Cot; i++)
            {
                S = 0;
                for (int j = 1; j <= So_Hang; j++)
                {
                    if( i == j)
                    {
                        S += arr[j, i];
                    }
                    
                }
                
            }
        }


        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.NhapMang();
            pr.InMatTran();
            pr.TongDong();
            pr.TongCot();
            pr.TongDuongCheo();
            Console.ReadKey();
        }
    }
}
