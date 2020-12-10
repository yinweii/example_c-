using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Th2
{
    class Program
    {
        public static Boolean isDuong(int n) //kiem tra mang duong
        {
            bool check = false;
            for(int i = 0;i<n;i++)
            {
                if(i > 0)
                {
                   check = true;
                }
            }
            if (check) return true;
            else return false;
        }
        public static Boolean isSnt(int n) // KIEM TRA SO NGUYEN TO
        {
            bool check = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    check = false;
                }
            }
            if (check) return true;
            else return false;
        }
        public static Boolean isScp(int n) // KIEM TRA SO CHINH PHUONG
        {
            bool check = false;
            int i = 0;
            while( i*i <= n)
            {
                if (i*i == n)
                {
                    check =true;
                }
                i++;
            }
            if (check) return true;
            else return false;

        }
        public static Boolean isHh(int n) // KIEM TRA SO hoan hao
        {
            bool check = false;
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum = sum + i;
                if(sum == n)
                {
                    check = true;
                }
            }
            
            if (check) return true;
            else return false;

        }
        public void Delete(int []arr,int n)
        {
            Console.WriteLine("Nhap vi tri can xoa: ");
           int  k = Convert.ToInt32(Console.ReadLine());
            if( k> n-1 || k <= 0)
            {
                Console.WriteLine("vi tri xoa khong hop le:");
            }
            else
            {
                for(int i = k; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];

                }n--;
                Console.WriteLine("mang sau khi xoa: ");
                for(int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            
        }
       
        public void SapXepTang(int[] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if( arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("Mang sap xep giam: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

        }
        public void deleteX(int[] arr, int n)
        {
            Console.WriteLine("Nhap so can xoa: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i =0;i< n; i++)
            {
                if( arr[i] == x)
                {
                    for(int j = i; j < n-1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    n--;
                    i--;
                }
            }
           
            Console.WriteLine("mang sau khi xoa: ");
            for (int i = 0; i < n; i++)
            {
                
                Console.Write("{0} ", arr[i]);
            }
           

        }
        static void Main(string[] args)

        {
            Program pr = new Program();
            
            //NHAP MANG
            Console.Write("nhap so phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("phan tu thu {0} :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //In Mang
            Console.WriteLine("mang vua nhap: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
           
            // in mang so duong
            Console.WriteLine("mang so duong la: ");
            for(int i = 0; i < arr.Length; i++)
            {
                if (isDuong(arr[i]))
                {
                    Console.Write("{0} ", arr[i]);
                }

            }
            //in phan thu lam nhat
           
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if( arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Max:{0} ",max);
            Console.WriteLine("Min:{0} ",min);
           
            //----------->in so nguyen to<--------------
            Console.WriteLine();
            Console.WriteLine("mang so nguyen to la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (isSnt(arr[i]))
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
          
            //----------->in CHINH PHUONG<--------------
            Console.WriteLine();
            Console.WriteLine("mang so chinh phuong la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (isScp(arr[i]))
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            
            //----------->in HOAN HAO<--------------
            Console.WriteLine();
            Console.WriteLine("mang so Hoan Hao la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (isHh(arr[i]))
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            pr.SapXepTang(arr, n);
            pr.Delete(arr,n);
            pr.deleteX(arr,n);
            Console.ReadKey();
        }
        
        
    }
    
}
