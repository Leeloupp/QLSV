using System;
using System.Collections.Generic;
 
namespace BaiTapQLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
    
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
 
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Tra ve danh sach cac thanh vien gioi tinh nam **");
                Console.WriteLine("**  3. Tra ve danh sach nguoi gia nhat               **");
                Console.WriteLine("**  4. Tra ve danh sach moi chi chua Ho Va Ten       **");
                Console.WriteLine("**  5. Tra ve danh sach nguoi sinh nam >2000         **");
                Console.WriteLine("**  6. Tra ve danh sach nguoi sinh nam 2000          **");
                Console.WriteLine("**  7. Tra ve danh sach nguoi sinh nam <2000         **");
                Console.WriteLine("**  8. Tra ve danh sach nguoi sinh o Ha Noi          **");
                Console.WriteLine("**  9. Hien thi danh sach sinh vien.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        quanLySinhVien.NhapSinhVien();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        break;
                    case 4:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n4. Hien thi danh sach sinh vien chi gom ho va ten.");
                            quanLySinhVien.HoVaTen(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 5:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n5. Hien thi danh sach sinh vien nam sinh lon hon 2000.");
                            quanLySinhVien.NguoiCaoTuoi(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    
                    case 9:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}