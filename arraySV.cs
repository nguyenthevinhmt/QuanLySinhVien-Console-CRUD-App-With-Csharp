//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace L0_Csharp
//{
//    internal class arraySV
//    {
//        public int n { get; set; }
//        public SinhVien[] listSV { get; set; }
//        //public arraySV()
//        //{
//        //    this.n = n;
//        //    this.listSV = new SinhVien[n];
//        //}

       
//        //nhap 
//        public void nhapSV()
//        {
//            Console.WriteLine("Nhap vao so luong sinh vien: ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            this.n = n;
//            listSV = new SinhVien[n];
//            for(int i = 0; i < n; i++)
//            {
//                SinhVien sv = new SinhVien();
//                Console.WriteLine($"Nhap vao sinh vien thu {i + 1}");
//                sv.ID = i+1;
//                try
//                {

//                    Console.WriteLine("Nhap vao ten: ");
//                    sv.Name = Console.ReadLine();
//                    if (sv.Name == "")
//                    {
//                        Console.WriteLine("Khong duoc bo trong truong nay!");
//                        Console.WriteLine("Nhap lai ten hop le: ");
//                        sv.Name = Console.ReadLine();
//                    }
//                    else if (sv.Name.Length > 100)
//                    {
//                        Console.WriteLine("Truong nay khong duoc vuot qua 100 ki tu!");
//                        Console.WriteLine("Nhap lai ten hop le: ");
//                        sv.Name = Console.ReadLine();
//                    }
//                    Console.WriteLine("Nhap vao ngay thang nam sinh: ");
//                    Console.WriteLine("Chu y: Dinh dang dd/mm/yyyy");
//                    sv.DoB = Convert.ToDateTime(Console.ReadLine());
//                    if (sv.DoB <= new DateTime(1990, 1, 1))
//                    {
//                        Console.WriteLine("Nam sinh phai bat dau tu nam 1990");
//                        Console.WriteLine("Nhap lai ngay thang nam sinh: ");
//                        sv.DoB = Convert.ToDateTime(Console.ReadLine());
//                    }
//                    Console.WriteLine("Nhap vao dia chi: ");
//                    sv.Address = Console.ReadLine();
//                    if (sv.Address == "")
//                    {
//                        Console.WriteLine("Khong duoc bo trong truong nay!");
//                        Console.WriteLine("Nhap lai dia chi hop le: ");
//                        sv.Address = Console.ReadLine();
//                    }
//                    else if (sv.Address.Length > 300)
//                    {
//                        Console.WriteLine("Truong nay khong duoc vuot qua 300 ki tu!");
//                        Console.WriteLine("Nhap lai dia chi hop le: ");
//                        sv.Address = Console.ReadLine();
//                    }
//                    Console.WriteLine("Nhap vao chieu cao (don vi cm): ");
//                    sv.Height = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Nhap vao can nang: ");
//                    sv.Weight = Convert.ToDouble(Console.ReadLine());
//                    if (sv.Height < 50.0 || sv.Height > 300.0)
//                    {
//                        Console.WriteLine("Chieu cao khong hop le");
//                        Console.WriteLine("Moi nhap lai chieu cao hop le (don vi cm): ");
//                        sv.Height = Convert.ToDouble(Console.ReadLine());
//                    }
//                    if (sv.Weight < 5.0 || sv.Weight > 1000.0)
//                    {
//                        Console.WriteLine("Can nang khong hop le");
//                        Console.WriteLine("Moi nhap lai can nang hop le (don vi kg): ");
//                        sv.Weight = Convert.ToDouble(Console.ReadLine());
//                    }
//                    Console.WriteLine("Nhap vao ID sinh vien: ");
//                    sv.StudentID = (int)Convert.ToInt64(Console.ReadLine());
//                    if (sv.StudentID < 1000000000 || sv.StudentID > 9999999999)
//                    {
//                        Console.WriteLine("Student ID khong hop le");
//                        Console.WriteLine("Moi nhap lai Student ID (gom 10 chu so khong trung nhau): ");
//                        sv.StudentID = Convert.ToInt32(Console.ReadLine());
//                    }
//                    Console.WriteLine("Nhap vao ten truong: ");
//                    sv.SchoolName = Console.ReadLine();
//                    if (sv.SchoolName == "")
//                    {
//                        Console.WriteLine("Truong nay khong duoc bo trong");
//                        Console.WriteLine("Moi nhap lai ten truong phu hop: ");
//                        sv.SchoolName = Console.ReadLine();
//                    }
//                    if (sv.SchoolName.Length > 200)
//                    {
//                        Console.WriteLine("Khong duoc vuot qua 200 ki tu");
//                        Console.WriteLine("Moi nhap lai ten truong phu hop:");
//                        sv.SchoolName = Console.ReadLine();

//                    }
//                    Console.WriteLine("Nhap vao nam bat dau hoc: ");
//                    sv.StartYear = Convert.ToInt32(Console.ReadLine());
//                    if (sv.StartYear < 1990 || sv.StartYear > 9999)
//                    {
//                        Console.WriteLine("Nam bat dau hoc khong hop le: ");
//                        Console.WriteLine("Moi nhap lai nam bat dau hoc hop le: ");
//                        sv.StartYear = Convert.ToInt32(Console.ReadLine());
//                    }
//                    Console.WriteLine("Nhap vao GPA: ");
//                    sv.GPA = Convert.ToDouble(Console.ReadLine());
//                    if (sv.GPA < 0.0 || sv.GPA > 10.0)
//                    {
//                        Console.WriteLine("GPA khong hop le:");
//                        Console.WriteLine("Moi nhap lai GPA hop le ( 0.0 - 10.0):");
//                        sv.GPA = Convert.ToDouble(Console.ReadLine());
//                    }
//                }
//                catch (Exception error)
//                {
//                    Console.WriteLine("Co loi nhap lieu");
//                    Console.WriteLine(error.Message);
//                    Console.WriteLine("Moi nhap lai");
//                    Console.WriteLine("========================================");
//                    nhapSV();
//                }
//                listSV[i] = sv;
//            }
//            Console.WriteLine("======================================================");
//            Console.WriteLine("Danh sách sinh viên vừa nhập: ");
//            showList();
//        }
//        //tìm kiếm theo ID
//        public SinhVien FindByID(int ID)
//        {
//            SinhVien? result = null;
//            if (listSV != null && listSV.Length > 0)
//            {
//                foreach (SinhVien sv in listSV)
//                {
//                    if (sv.ID == ID)
//                    {
//                        result = sv;
//                        SinhVien searchResult = sv;
//                        searchResult.outPutSv();
//                    }
//                }
//            }
//            return result;
//        }

//        //Update
//        public void UpdateSinhVien(int ID)
//        {
//            SinhVien sv = FindByID(ID);
//            if (sv != null)
//            {
//                Console.WriteLine("Nhap vao ten: ");
//                string Name = Console.ReadLine();
//                if (sv.Name == "")
//                {
//                    sv.Name = Name;
//                }
//                else if (sv.Name.Length > 100)
//                {
//                    Console.WriteLine("Truong nay khong duoc vuot qua 100 ki tu!");
//                    Console.WriteLine("Nhap lai ten hop le: ");
//                    sv.Name = Console.ReadLine();
//                }
//                Console.WriteLine("Nhap vao ngay thang nam sinh: ");
//                Console.WriteLine("Chu y: Dinh dang dd/mm/yyyy");
//                sv.DoB = Convert.ToDateTime(Console.ReadLine());
//                if (sv.DoB <= new DateTime(1990, 1, 1))
//                {
//                    Console.WriteLine("Nam sinh phai bat dau tu nam 1990");
//                    Console.WriteLine("Nhap lai ngay thang nam sinh: ");
//                    sv.DoB = Convert.ToDateTime(Console.ReadLine());
//                }
//                Console.WriteLine("Nhap vao dia chi: ");
//                string Address = Console.ReadLine();
//                if (sv.Address == "")
//                {
                   
//                    sv.Address = Address;
//                }
//                else if (sv.Address.Length > 300)
//                {
//                    Console.WriteLine("Truong nay khong duoc vuot qua 300 ki tu!");
//                    Console.WriteLine("Nhap lai dia chi hop le: ");
//                    sv.Address = Console.ReadLine();
//                }
//                Console.WriteLine("Nhap vao chieu cao (don vi cm): ");
//                sv.Height = Convert.ToDouble(Console.ReadLine());
//                Console.WriteLine("Nhap vao can nang: ");
//                sv.Weight = Convert.ToDouble(Console.ReadLine());
//                if (sv.Height < 50.0 || sv.Height > 300.0)
//                {
//                    Console.WriteLine("Chieu cao khong hop le");
//                    Console.WriteLine("Moi nhap lai chieu cao hop le (don vi cm): ");
//                    sv.Height = Convert.ToDouble(Console.ReadLine());
//                }
//                if (sv.Weight < 5.0 || sv.Weight > 1000.0)
//                {
//                    Console.WriteLine("Can nang khong hop le");
//                    Console.WriteLine("Moi nhap lai can nang hop le (don vi kg): ");
//                    sv.Weight = Convert.ToDouble(Console.ReadLine());
//                }
//                Console.WriteLine("Nhap vao ID sinh vien: ");
//                sv.StudentID = (int)Convert.ToInt64(Console.ReadLine());
//                if (sv.StudentID < 1000000000 || sv.StudentID > 9999999999)
//                {
//                    Console.WriteLine("Student ID khong hop le");
//                    Console.WriteLine("Moi nhap lai Student ID (gom 10 chu so khong trung nhau): ");
//                    sv.StudentID = Convert.ToInt32(Console.ReadLine());
//                }
//                Console.WriteLine("Nhap vao ten truong: ");
//                sv.SchoolName = Console.ReadLine();
//                if (sv.SchoolName == "")
//                {
//                    Console.WriteLine("Truong nay khong duoc bo trong");
//                    Console.WriteLine("Moi nhap lai ten truong phu hop: ");
//                    sv.SchoolName = Console.ReadLine();
//                }
//                if (sv.SchoolName.Length > 200)
//                {
//                    Console.WriteLine("Khong duoc vuot qua 200 ki tu");
//                    Console.WriteLine("Moi nhap lai ten truong phu hop:");
//                    sv.SchoolName = Console.ReadLine();

//                }
//                Console.WriteLine("Nhap vao nam bat dau hoc: ");
//                sv.StartYear = Convert.ToInt32(Console.ReadLine());
//                if (sv.StartYear < 1990 || sv.StartYear > 9999)
//                {
//                    Console.WriteLine("Nam bat dau hoc khong hop le: ");
//                    Console.WriteLine("Moi nhap lai nam bat dau hoc hop le: ");
//                    sv.StartYear = Convert.ToInt32(Console.ReadLine());
//                }
//                Console.WriteLine("Nhap vao GPA: ");
//                sv.GPA = Convert.ToDouble(Console.ReadLine());
//                if (sv.GPA < 0.0 || sv.GPA > 10.0)
//                {
//                    Console.WriteLine("GPA khong hop le:");
//                    Console.WriteLine("Moi nhap lai GPA hop le ( 0.0 - 10.0):");
//                    sv.GPA = Convert.ToDouble(Console.ReadLine());
//                }
//            }
//            else
//            {
//                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", ID);
//            }
//        }

//        //delete
//        public SinhVien[] deleteByID(int id)
//        {
//            SinhVien[] newListSV = new SinhVien[listSV.Length - 1];
//            for(int i = 0; i < id; i++)
//            {
//                newListSV[i] = listSV[i];
//            }
//            for(int i = id + 1; i < listSV.Length; i++)
//            {
//                newListSV[i - 1] = listSV[i];
//            }
//            return newListSV;
//        }

//        public void showList()
//        {
//            foreach (var sv in listSV)
//            {
//                sv.outPutSv();

//            }
//        }





//    }
//}
