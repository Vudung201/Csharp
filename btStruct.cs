using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Struct
{
    class Program
    {
        enum dienSinhVien{
            hoNgheo,
            hoCanNgheo,
            khaGia,
        }
        struct SinhVien
        {
            public int MaSV_109;
            public string HoTen_109;
            public double DiemToan_109;
            public double DiemLy_109;
            public double DiemVan_109;
            public int dienSinhVien_109;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma SV: ");
            SV.MaSV_109 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen_109 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan_109 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy_109 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan_109 = Double.Parse(Console.ReadLine());
            Console.Write(" Dien Sinh Vien: ");
            SV.dienSinhVien_109 = int.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSV_109);
            Console.WriteLine(" Ho ten: " + SV.HoTen_109);
            Console.WriteLine(" Diem toan: " + SV.DiemToan_109);
            Console.WriteLine(" Diem ly: " + SV.DiemLy_109);
            Console.WriteLine(" Diem van: " + SV.DiemVan_109);
            if(SV.dienSinhVien_109 == (int )dienSinhVien.hoNgheo)
            {
                Console.WriteLine(" Thuoc dien: Ho Ngheo");
            }
            else if (SV.dienSinhVien_109 == (int)dienSinhVien.hoCanNgheo)
            {
                Console.WriteLine(" Thuoc dien: Ho Can Ngheo");
            }
            else
            {
                Console.WriteLine(" Thuoc dien: Kha Gia");
            }
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan_109 + SV.DiemLy_109 + SV.DiemVan_109) / 3;
        }

        static void Main(string[] args)
        {
            
           
            int n_109;
            do
            {
                Console.Write("Nhap SL sinh vien: ");
                n_109 = int.Parse(Console.ReadLine());
            } while (n_109 <= 0);
            SinhVien[] sv109 = new SinhVien[n_109];
            for (int i = 0;i<n_109;i++)
            {
                Console.Write("Nhap vao SV[{0}]: \n",i+1);
                NhapThongTinSinhVien(out sv109[i]);
            }

            Console.WriteLine("DANH SACH DUYEN SINH VIEN: ");
            int d = 0;
            foreach (SinhVien sv in sv109)
            {
                Console.WriteLine("\nSinh vien thu {0}: \n",d+1);
                XuatThongTinSinhVien(sv);
                d++;
            }


            string searchSV_109;
            Console.Write("\nNhap vao ten sv can tim kiem: ");
            searchSV_109 = Console.ReadLine();
            foreach (SinhVien sv in sv109)
            {
                if (sv.HoTen_109 == searchSV_109)
                {
                    Console.WriteLine("Diem TB cua sinh vien {0} la: {1} ",searchSV_109,DiemTBSinhVien(sv));
                }
            }
            Console.ReadKey();
        }
    }
}

