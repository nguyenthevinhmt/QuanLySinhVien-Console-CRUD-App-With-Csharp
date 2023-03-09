using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0_Csharp
{
    internal class ListStudent
    {

        public List<SinhVien> listSv;
        public ListStudent()
        {
            listSv = new List<SinhVien>() { };
        }

        //Auto increament
        public int autoIncreamentID()
        {
            int maxID = 1;
            if (listSv != null && listSv.Count > 0)
            {
                maxID = listSv[0].ID;
                foreach (SinhVien sv in listSv)
                {
                    if (maxID < sv.ID)
                    {
                        maxID = sv.ID;
                    }
                }
                maxID++;
            }
            return maxID;
        }
        //Check trung ID sinh vien
        public bool checkIdStudent(string sv)
        {
            bool check = true;
            foreach (var item in listSv)
            {
                if (item.StudentID.Contains(sv))
                {
                    check = false;
                    //Console.WriteLine("ID sinh vien da ton tai, moi nhap lai ID khac: ");
                }

            }
            return check;
        }
        //Nhap
        public void inputSv()
        {
            try
            {

                SinhVien sv = new SinhVien();
                sv.ID = autoIncreamentID();
                Console.WriteLine("Nhap vao ten: ");
                sv.Name = Console.ReadLine();
                if (sv.Name == "")
                {
                    Console.WriteLine("Khong duoc bo trong truong nay!");
                    Console.WriteLine("Nhap lai ten hop le: ");
                    sv.Name = Console.ReadLine();
                }
                else if (sv.Name.Length > 100)
                {
                    Console.WriteLine("Truong nay khong duoc vuot qua 100 ki tu!");
                    Console.WriteLine("Nhap lai ten hop le: ");
                    sv.Name = Console.ReadLine();
                }
                Console.WriteLine("Nhap vao ngay thang nam sinh: ");
                Console.WriteLine("Chu y: Dinh dang dd/mm/yyyy");
                sv.DoB = Convert.ToDateTime(Console.ReadLine());
                if (sv.DoB <= new DateTime(1990, 1, 1))
                {
                    Console.WriteLine("Nam sinh phai bat dau tu nam 1990");
                    Console.WriteLine("Nhap lai ngay thang nam sinh: ");
                    sv.DoB = Convert.ToDateTime(Console.ReadLine());
                }
                Console.WriteLine("Nhap vao dia chi: ");
                sv.Address = Console.ReadLine();
                if (sv.Address == "")
                {
                    Console.WriteLine("Khong duoc bo trong truong nay!");
                    Console.WriteLine("Nhap lai dia chi hop le: ");
                    sv.Address = Console.ReadLine();
                }
                else if (sv.Address.Length > 300)
                {
                    Console.WriteLine("Truong nay khong duoc vuot qua 300 ki tu!");
                    Console.WriteLine("Nhap lai dia chi hop le: ");
                    sv.Address = Console.ReadLine();
                }
                Console.WriteLine("Nhap vao chieu cao (don vi cm): ");
                sv.Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhap vao can nang: ");
                sv.Weight = Convert.ToDouble(Console.ReadLine());
                if (sv.Height < 50.0 || sv.Height > 300.0)
                {
                    Console.WriteLine("Chieu cao khong hop le");
                    Console.WriteLine("Moi nhap lai chieu cao hop le (don vi cm): ");
                    sv.Height = Convert.ToDouble(Console.ReadLine());
                }
                if (sv.Weight < 5.0 || sv.Weight > 1000.0)
                {
                    Console.WriteLine("Can nang khong hop le");
                    Console.WriteLine("Moi nhap lai can nang hop le (don vi kg): ");
                    sv.Weight = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Nhap vao ID sinh vien: ");
                sv.StudentID = Console.ReadLine();
                if (sv.StudentID.Length != 10)
                {
                    Console.WriteLine("Student ID khong hop le");
                    Console.WriteLine("Moi nhap lai Student ID (gom 10 chu so khong trung nhau): ");
                    sv.StudentID = Console.ReadLine();
                }
                if (checkIdStudent(sv.StudentID) == false)
                {
                    Console.WriteLine("ID sinh vien da ton tai, moi nhap lai ID khac: ");
                    sv.StudentID = Console.ReadLine();
                }
                Console.WriteLine("Nhap vao ten truong: ");
                sv.SchoolName = Console.ReadLine();
                if (sv.SchoolName == "")
                {
                    Console.WriteLine("Truong nay khong duoc bo trong");
                    Console.WriteLine("Moi nhap lai ten truong phu hop: ");
                    sv.SchoolName = Console.ReadLine();
                }
                if (sv.SchoolName.Length > 200)
                {
                    Console.WriteLine("Khong duoc vuot qua 200 ki tu");
                    Console.WriteLine("Moi nhap lai ten truong phu hop:");
                    sv.SchoolName = Console.ReadLine();

                }
                Console.WriteLine("Nhap vao nam bat dau hoc: ");
                sv.StartYear = Convert.ToInt32(Console.ReadLine());
                if (sv.StartYear < 1990 || sv.StartYear > 9999)
                {
                    Console.WriteLine("Nam bat dau hoc khong hop le: ");
                    Console.WriteLine("Moi nhap lai nam bat dau hoc hop le: ");
                    sv.StartYear = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Nhap vao GPA: ");
                sv.GPA = Convert.ToDouble(Console.ReadLine());
                if (sv.GPA < 0.0 || sv.GPA > 10.0)
                {
                    Console.WriteLine("GPA khong hop le:");
                    Console.WriteLine("Moi nhap lai GPA hop le ( 0.0 - 10.0):");
                    sv.GPA = Convert.ToDouble(Console.ReadLine());
                }
                sv.setRank();
                listSv.Add(sv);

            }
            catch (Exception error)
            {
                Console.WriteLine("Co loi nhap lieu");
                Console.WriteLine(error.Message);
                Console.WriteLine("Moi nhap lai");
                Console.WriteLine("========================================");
                inputSv();
            }
        }
        //Xuat
        public void XuatDS()
        {
            if (listSv.Count > 0)
            {
                foreach (var sv in listSv)
                {
                    sv.outPutSv();
                }

            }
            else
            {
                Console.WriteLine("Danh sach trong!");
            }
        }

        //Tim bang ID
        public SinhVien FindByID(int id)
        {
            SinhVien result = null;
            if (listSv != null && listSv.Count > 0)
            {
                foreach (var sv in listSv)
                {
                    if (sv.ID == id)
                    {
                        result = sv;
                    }
                }
            }
            return result;
        }
        //Count
        public int Count()
        {
            int count = 0;
            if (listSv != null)
            {
                count = listSv.Count;

            }
            return count;
        }

        //Update
        public void UpdateSV(int id)
        {
            SinhVien sv = FindByID(id);
            if (sv != null)
            {
                try
                {
                    Console.WriteLine("Nhap vao ten: ");
                    string Name = Console.ReadLine();
                    if (Name != null && Name.Length > 0)
                    {
                        sv.Name = Name;
                    }
                    Console.WriteLine("Nhap vao ngay thang nam sinh: ");
                    Console.WriteLine("Chu y: Dinh dang dd/mm/yyyy");
                    DateTime DoB = Convert.ToDateTime(Console.ReadLine());
                    if (DoB != null && DoB.ToString().Length > 0)
                    {
                        sv.DoB = DoB;
                    }
                    Console.WriteLine("Nhap vao dia chi: ");
                    string Address = Console.ReadLine();
                    if (Address != null && Address.Length > 0)
                    {
                        sv.Address = Address;
                    }

                    Console.WriteLine("Nhap vao chieu cao (don vi cm): ");
                    Double Height = Convert.ToDouble(Console.ReadLine());
                    if (Height != null)
                    {
                        sv.Height = Height;
                    }
                    Console.WriteLine("Nhap vao can nang: ");
                    Double Weight = Convert.ToDouble(Console.ReadLine());
                    if (Weight != null)
                    {
                        sv.Weight = Weight;
                    }
                    Console.WriteLine("Nhap vao ID sinh vien: ");
                    string StudentID = Console.ReadLine();
                    if ((StudentID.Length == 10) && StudentID != null)
                    {

                        sv.StudentID = StudentID;
                    }
                    Console.WriteLine("Nhap vao ten truong: ");
                    string SchoolName = Console.ReadLine();
                    if (SchoolName == "")
                    {

                        sv.SchoolName = SchoolName;
                    }

                    Console.WriteLine("Nhap vao nam bat dau hoc: ");
                    int StartYear = Convert.ToInt32(Console.ReadLine());
                    if (StartYear != null)
                    {

                        sv.StartYear = StartYear;
                    }
                    Console.WriteLine("Nhap vao GPA: ");
                    Double GPA = Convert.ToDouble(Console.ReadLine());
                    if (GPA != null)
                    {

                        sv.GPA = GPA;
                    }
                    sv.setRank();
                }
                catch (Exception error)
                {
                    Console.WriteLine("Co loi nhap lieu");
                    Console.WriteLine(error.Message);
                    Console.WriteLine("Moi nhap lai");
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nhap vao ten: ");
                    string Name = Console.ReadLine();
                    sv.Name = Name;
                    if (Name != "")
                    {
                        sv.Name = Name;
                    }
                    Console.WriteLine("Nhap vao ngay thang nam sinh: ");
                    Console.WriteLine("Chu y: Dinh dang dd/mm/yyyy");
                    DateTime DoB = Convert.ToDateTime(Console.ReadLine());
                    if (DoB != null)
                    {
                        sv.DoB = DoB;
                    }
                    Console.WriteLine("Nhap vao dia chi: ");
                    string Address = Console.ReadLine();
                    if (Address != null && Address.Length > 0)
                    {
                        sv.Address = Address;
                    }

                    Console.WriteLine("Nhap vao chieu cao (don vi cm): ");
                    Double Height = Convert.ToDouble(Console.ReadLine());
                    if (Height != null)
                    {
                        sv.Height = Height;
                    }
                    Console.WriteLine("Nhap vao can nang: ");
                    Double Weight = Convert.ToDouble(Console.ReadLine());
                    if (Weight != null)
                    {
                        sv.Weight = Weight;
                    }
                    Console.WriteLine("Nhap vao ID sinh vien: ");
                    string StudentID = Console.ReadLine();
                    if (StudentID != null)
                    {
                        sv.StudentID = StudentID;
                    }
                    Console.WriteLine("Nhap vao ten truong: ");
                    string SchoolName = Console.ReadLine();
                    if (SchoolName == "")
                    {

                        sv.SchoolName = SchoolName;
                    }

                    Console.WriteLine("Nhap vao nam bat dau hoc: ");
                    int StartYear = Convert.ToInt32(Console.ReadLine());
                    if (StartYear != null)
                    {
                        sv.StartYear = StartYear;
                    }
                    Console.WriteLine("Nhap vao GPA: ");
                    Double GPA = Convert.ToDouble(Console.ReadLine());
                    if (GPA != null)
                    {

                        sv.GPA = GPA;
                    }
                    sv.setRank();
                    //sv.rank = _rank;
                }
            }
            else
            {
                Console.WriteLine("ID khong ton tai");
            }
        }
        //Delete
        public bool DeleteSV(int id)
        {
            bool IsDeleted = false;
            SinhVien sv = FindByID(id);
            if (sv != null)
            {
                IsDeleted = listSv.Remove(sv);
            }
            return IsDeleted;
        }


        public enum Rank { Kem, Yeu, TrungBinh, Kha, Gioi, XuatSac }

        //In danh sach theo hoc luc
        public List<SinhVien> OutputByRank(string hocluc)
        {
            List<SinhVien> lsSv = new List<SinhVien>();
            foreach (var sv in listSv)
            {
                if (sv.rank.ToString().Contains(hocluc))
                {
                    lsSv.Add(sv);
                }
            }
            return lsSv;
        }





        //Thong ke % hoc luc, sap xep tu cao xuong thap cach 1
        //public void ThongKe()
        //{
        //    if (listSv != null && listSv.Count > 0)
        //    {
        //        //% cho hoc luc "Kem"
        //        int count = 0;
        //        int percent = (count / listSv.Count) * 100;
        //        foreach (var sv in listSv)
        //        {
        //            if (sv.rank.ToString().Contains("Kem"))
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine($"Ti le hoc sinh co hoc luc kem la: {percent}");
        //        count = 0;
        //        foreach (var sv in listSv)
        //        {
        //            if (sv.rank.ToString().Contains("Yeu"))
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine($"Ti le hoc sinh co hoc luc yeu la: {percent}");
        //        count = 0;
        //        foreach (var sv in listSv)
        //        {
        //            if (sv.rank.ToString().Contains("TrungBinh"))
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine($"Ti le hoc sinh co hoc luc trung binh la: {percent}");
        //        count = 0;
        //        foreach (var sv in listSv)
        //        {
        //            if (sv.rank.ToString().Contains("Kha"))
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine($"Ti le hoc sinh co hoc luc kha la: {percent}");
        //        count = 0;
        //        foreach (var sv in listSv)
        //        {
        //            if (sv.rank.ToString().Contains("Gioi"))
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine($"Ti le hoc sinh co hoc luc gioi la: {percent}");
        //        count = 0;
        //        foreach (var sv in listSv)
        //        {
        //            if (sv.rank.ToString().Contains("XuatSac"))
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine($"Ti le hoc sinh co hoc luc XuatSac la: {percent}");


        //    }
        //}

        //Thong ke % sinh vien tuong ung voi hoc luc
        public void ThongKe()
        {
            if (listSv != null && listSv.Count > 0)
            {
                var result = listSv
                             .GroupBy(s => s.rank)
                             .Select(g => new{
                                 listSvRank = g.Key,
                                 listSvPercentage = (double)g.Count() / listSv.Count * 100})
                                 .OrderByDescending(r => r.listSvPercentage);
                foreach (var i in result)
                {
                    Console.WriteLine("{0}: {1}%", i.listSvRank, i.listSvPercentage);
                }
            }
        }

        //Tinh % GPA cua moi sinh vien trong danh sach
        public void PercentAvg()
        {
            Dictionary<string, double> percentageMap = new Dictionary<string, double>();
            double sum = 0;
            foreach (SinhVien sv in listSv)
            {
                sum += sv.GPA;
            }
            double average = sum / listSv.Count;

            foreach (SinhVien sv in listSv)
            {
                double percentage = (sv.GPA / average) * 100;
                percentageMap[sv.Name] = percentage;
            }

            foreach (KeyValuePair<string, double> pair in percentageMap)
            {
                Console.WriteLine("{0}: {1}% of average score", pair.Key, pair.Value);
            }
        }
        //Luu file
        public void SaveFile()
        {
            using (StreamWriter writer = new StreamWriter("students.txt"))
            {
                // Ghi danh sách sinh viên vào tập tin
                foreach (SinhVien sv in listSv)
                {
                    writer.WriteLine($"{sv.ID},{sv.Name},{sv.DoB},{sv.Address}, {sv.Height}, {sv.Weight}" +
                        $"{sv.StudentID}, {sv.SchoolName}, {sv.StartYear},{sv.GPA},{sv.rank}");
                }
            }

            Console.WriteLine("Danh sách sinh viên đã được lưu vào tập tin students.txt.");
        }



    }
}

