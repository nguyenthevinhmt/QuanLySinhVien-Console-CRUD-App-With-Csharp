using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0_Csharp
{
    internal class Nguoi
    {        
        public int ID { get; set; }

        //[Required]
        //[StringLength(100)]
        public string Name { get; set; }

        //[Required]

        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Nguoi(int _ID, string _Name, DateTime _DoB, string _Address, double _Height, double _Weight) {
            ID = _ID;   
            Name = _Name;
            DoB = _DoB;
            Address = _Address;
            Height = _Height;
            Weight = _Weight;
        }
        public Nguoi() { }
        public virtual void toString()
        {
            Console.WriteLine(
                 $"ID: {this.ID}, Name: {this.Name}, Date of Birth: {this.DoB}, Address: {this.Address}, " +
                $"Height: {this.Height}, Weight: {this.Weight}");
        }
    }
}
