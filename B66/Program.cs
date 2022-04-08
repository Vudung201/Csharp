using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B66
{
    class Program
    {
        static void deleteValue(int[] a, ref int n, int pos)
        {
            for (int i = pos; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            // Giam so luong phan tu sau khi xoa.
            --n;
        }
        static void deleteArr(int[] a, ref int n,int pos)
        {
            for (int i = pos+1; i < n; i++)
            {
               if(a[pos] == a[i])
                {
                    deleteValue(a,ref n, i);
                }
            }
        }

        static void nhapN(out int n)
        {
            do
            {
                Console.Write("nhap n [1-99] : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 && n > 99);
        }
        static void xuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[200];
            int n;

            nhapN(out n);
            Random ran = new Random();
            Console.Write("Danh sach :");
            for (int i = 0;i<n;i++)
            {
                a[i] = ran.Next(-100,100);
                Console.Write(a[i]+" ");
            }
            int max = a[0], min = a[0], posMax = 0 ;

            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    posMax = i;
                }

                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.Write("\nMin la: {0} --- Max la: {1}", min, max);

            deleteArr(a,ref n,posMax);

            Console.Write("\nMang moi: ");
            xuatMang(a,n);

            Console.ReadKey();
        }
    }
}
