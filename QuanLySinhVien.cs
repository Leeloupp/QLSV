using System;
using System.Collections.Generic;
 
namespace BaiTapQLSV
{
    class QuanLySinhVien
    {
        private List<SinhVien> ListSinhVien = null;
        
        public QuanLySinhVien() {
            ListSinhVien = new List<SinhVien>();
            
        }
        
        /**
         * Hàm tạo ID tăng dần cho nhân viên
         */
        private int GenerateID()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].ID;
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (max < sv.ID)
                    {
                        max = sv.ID;
                    }
                }
                max++;
            }
            return max;
        }
 
        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }
 
        public void NhapSinhVien()
        {
            // Khởi tạo một sinh viên mới
            SinhVien sv = new SinhVien();
            sv.ID = GenerateID();
            Console.Write("Fist Name: ");
            sv.FistName = Convert.ToString(Console.ReadLine());
 
            Console.Write("Last Name: ");
            sv.LastName = Convert.ToString(Console.ReadLine());
 
            Console.Write("Gender: ");
            sv.Gender = Convert.ToString(Console.ReadLine());
 
            Console.Write("Date Of Birth: ");
            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime InputTime = new DateTime(year, month, day);
            sv.DateOfBirth = InputTime;
            
 
            Console.Write("Phone Number: ");
            sv.PhoneNumber = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Birth Place: ");
            sv.BirthPlace = Convert.ToString(Console.ReadLine());

            Console.Write("Age: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Graduated: ");
            sv.Graduated = Convert.ToString(Console.ReadLine());
 
            // TinhDTB(sv);
            // XepLoaiHocLuc(sv);
 
            ListSinhVien.Add(sv);
        }
    
        public void ShowSinhVien(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 10} {4, 25} {5, 25} {6, 25} {7, 10} {8, 18}",
                  "ID", "Fist Name", "Last Name", "Gender", "Date Of Birth", "Phone Number", "Birth Place", "Age", "Is Graduated");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 10} {4, 25} {5, 25} {6, 25} {7, 10} {8, 18}",
                                      sv.ID, sv.FistName, sv.LastName, sv.Gender, sv.DateOfBirth, sv.PhoneNumber, sv.BirthPlace,
                                      sv.Age, sv.Graduated);
                }
            }
            Console.WriteLine();
        }
        public void HoVaTen(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} ",
                  "ID", "Fist Name", "Last Name");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} ",
                                      sv.ID, sv.FistName, sv.LastName);
                }
            }
            Console.WriteLine();
        }
        public void NguoiCaoTuoi(SinhVien sv){
            if(sv.year >2000){
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 10} {4, 25} {5, 25} {6, 25} {7, 10} {8, 18}",
                  "ID", "Fist Name", "Last Name", "Gender", "Date Of Birth", "Phone Number", "Birth Place", "Age", "Is Graduated");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 10} {4, 25} {5, 25} {6, 25} {7, 10} {8, 18}",
                                      sv.ID, sv.FistName, sv.LastName, sv.Gender, sv.DateOfBirth, sv.PhoneNumber, sv.BirthPlace,
                                      sv.Age, sv.Graduated);
                }
            }
            Console.WriteLine();
            }else{
                Console.WriteLine("Khong co ai ca");
            }
        }
        
        /*
         * Hàm trả về danh sách sinh viên hiện tại
         */
        public List<SinhVien> getListSinhVien()
        {
            
            return ListSinhVien;
        }
    }
}