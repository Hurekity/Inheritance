﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student:Human
    {
        public string Speciality { get; set; }  
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public string V1 { get; }
        public string V2 { get; }
        public int V3 { get; }
        public int V4 { get; }

        public Student(
            string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance)
            :base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstrucor:\t" + GetHashCode());
        }
        public Student(Human human, string speciality, double rating, double attendance) : base(human)
        {
            Speciality = speciality;    
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstructor:\t" + GetHashCode());
        }
        public Student(Student other):base(other)
        {
            this.Speciality = other.Speciality;
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            Console.WriteLine("SCopyConstructor:\t" + GetHashCode());
        }

     

        ~Student() { Console.WriteLine("SDestructor:\t" + GetHashCode()); }

        public void Info()
        {
            base.Info();
            Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality} {Group} {Rating} {Attendance}";
        }
    }
}
