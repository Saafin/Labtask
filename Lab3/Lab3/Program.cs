﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Saafin";
            s.Id = "19-39304-1";
            s.Department = "CSE";
            s.Cgpa = 3.65f;
            s.ShowInfo();
            Triangle t = new Triangle();
            t.X = 3;
            t.X = 4;
            t.Z = 7;
            t.ShowInfo();
            t.TestTriangle();
            Account a = new Account();
            a.AccName = "My Account";
            a.AcId = "1";
            a.Balance = 500;
            a.Deposit(12);
            a.Withdraw(40);
            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseId = "1011";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }

}
