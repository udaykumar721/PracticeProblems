﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestClass test = new TestClass();
            //test.Demo();
            //Console.ReadLine();
            //ChildClass childClass = new ChildClass();
            //childClass.ShowName();
            //childClass.DisplayAge();
            //childClass.Example();
            //Console.ReadLine();
            //OverloadParent overloadParent = new OverloadParent();
            //Console.WriteLine(overloadParent.Addition(4, 5));
            //Console.WriteLine(overloadParent.Addition(4, 5, 9));
            //Console.WriteLine(overloadParent.Addition(4, 5,9,6));
            //Console.ReadLine();
            //OverrideClass1 overrideClass = new OverrideClass1();
            //age age = new age();
            //DOB dOB = new DOB();
            //overrideClass.uday();
            //age.uday();
            //dOB.uday();

            //EncapsulationClass en = new EncapsulationClass();
            //en.SetBalance(1000);
            //en.GetBalance();

            //Student a = new Student();
            //a.Person();
            //a.work();
            //Measurments obj = new Measurments();
            //obj.Circle = "ball";
            //obj.Height = "11 inch";
            //obj.Square = "Box";
            //obj.Width = "12 inch";
            //obj.GetMeasurment();
            //obj.Getshape();

            Product obj = new Product();
            obj.Height = "11";
            obj.Width = "12";
            obj.GetMeasurment();
            obj.Circle = "circle";
            obj.Square = "square";
            obj.Getshape();
            obj.Price = 100;
            obj.Name = "name";
            

            Console.ReadLine();


        }
    }
}
