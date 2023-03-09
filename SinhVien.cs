using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L0_Csharp
{
    internal class SinhVien : Nguoi
    {
        
        public string StudentID { get; set; }
        public string SchoolName { get; set; }
        public int StartYear { get; set; }
        public double GPA{ get; set; }

        public enum Rank
        {
            Kem,Yeu,TrungBinh,Kha,Gioi,XuatSac
        }
        public Rank rank { get; set; }
        public SinhVien(int _ID, string _Name, DateTime _DoB, string _Address, double _Height,
            double _Weight,string _StudentID, string _SchoolName, int _StartYear, double _GPA)
            :base(_ID,_Name, _DoB, _Address,_Height,_Weight)
        {
            StudentID = _StudentID;
            SchoolName = _SchoolName;
            StartYear = _StartYear;
            GPA = _GPA;
            
        }

        public SinhVien()
        {

        }


        public Rank setRank()
        {
            if (GPA < 3)
            {
                rank = Rank.Kem;
                //rank = _rank;
            }
            if (GPA >= 3 && GPA < 5)
            {
                rank = Rank.Yeu;
                //rank = _rank;
            }
            if (GPA >= 5 && GPA < 6.5)
            {
                rank = Rank.TrungBinh;
                //rank = _rank;
            }
            if (GPA >= 6.5 && GPA < 7.5)
            {
                rank = Rank.Kha;
                //rank = _rank;
            }
            if (GPA >= 7.5 && GPA < 9)
            {
                rank = Rank.Gioi;
                //rank = _rank;
            }
            if (GPA >= 9)
            {
                rank = Rank.XuatSac;

            }
            return rank;
        }
        public virtual void outPutSv()
        {
            Console.WriteLine($"ID: {this.ID}, Name: {this.Name}, Date of Birth: {this.DoB}," +
                $" Address: {this.Address}, Height: {this.Height}, Weight: {this.Weight}, " +
                $"StudentID: {this.StudentID}, SchoolName: {this.SchoolName}, StartYear: {this.StartYear}, GPA: {this.GPA}, Rank: {this.rank}");
        }
        public void hocluc()
        {

        }
    }
}
