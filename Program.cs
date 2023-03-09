using System.Security.Cryptography.X509Certificates;

namespace L0_Csharp
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            ListStudent lstudent = new ListStudent();

            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
                Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
                Console.WriteLine("**  4. Tim kiem sinh vien theo ID.                   **");
                Console.WriteLine("**  5. Hien thi danh sach sinh vien                  **");
                Console.WriteLine("**  6. In danh sach sinh vien theo hoc luc           **");
                Console.WriteLine("**  7. Hien thi % diem trung binh cua cac sinh vien  **");
                Console.WriteLine("**  8. In ra danh sach sinh vien                     **");
                Console.WriteLine("**  0. Thoat chuong trinh                            **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        lstudent.inputSv();
                        break;
                    case 2:
                        Console.WriteLine("\n2. Cap nhat thong tin sinh vien");
                        if (lstudent.Count() > 0)
                        {
                            Console.WriteLine("Nhap vao ID sinh vien can update: ");
                            var id = Convert.ToInt32(Console.ReadLine());
                            lstudent.UpdateSV(id);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n3. Xoa sinh vien");
                        if (lstudent.Count() > 0)
                        {
                            Console.WriteLine("Nhap vao ID sinh vien can xoa: ");
                            var id = Convert.ToInt32(Console.ReadLine());
                            if (lstudent.DeleteSV(id))
                            {
                                Console.WriteLine("Xoa thanh cong");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n4. Tim kiem sinh vien theo ID");
                        if (lstudent.Count() > 0)
                        {
                            Console.WriteLine("Nhap vao ID sinh vien can tim kiem: ");
                            var id = Convert.ToInt32(Console.ReadLine());
                            lstudent.FindByID(id);
                            
                        }
                        else
                        {
                            Console.WriteLine("Sinh vien khong ton tai");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\n5. Xuat danh sach sinh vien: ");
                        if (lstudent.Count() > 0)
                        {
                            lstudent.XuatDS();
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong!");
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n6. In danh sach sinh vien theo hoc luc");
                        if(lstudent.Count() > 0)
                        {
                            Console.WriteLine("Nhap vao loai hoc luc");
                            string hocluc = Console.ReadLine();
                            var result = lstudent.OutputByRank(hocluc);
                            if (result != null && result.Count > 0)
                            {
                                foreach (var item in result)
                                {
                                    item.outPutSv();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Khong co sinh vien nao");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong!");
                        }
                        
                        break;
                    case 7:
                        Console.WriteLine("Thong ke % hoc luc: ");
                        Console.WriteLine("");
                        lstudent.ThongKe();
                        break;
                    case 8:
                        Console.WriteLine("Tinh phan tram diem trung binh cua moi sinh vien trong danh sach:");
                        lstudent.PercentAvg();
                        break;

                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        lstudent.SaveFile();
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