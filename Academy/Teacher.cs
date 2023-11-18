using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
     class Teacher:Human
    {
        public string Speciality { get; set; }
        public int Experience { get; set; }
        public Teacher
            (
               string lastName, string Firstname, int age,
               string speciality, int experience
            ) : base(lastName, Firstname, age)
        {
             Speciality = speciality;
            Experience = experience;
            Console.WriteLine("TConstrucor:\t" + GetHashCode());
        }
    ~Teacher() { Console.WriteLine("TDestructor:\t" + GetHashCode()); }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"{Speciality} {Experience}yo");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality} {Experience}yo";
        }
    }  
}
