using System;
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
            OverloadParent overloadParent = new OverloadParent();
            Console.WriteLine(overloadParent.Addition(4, 5));
            Console.WriteLine(overloadParent.Addition(4, 5, 9));
            Console.WriteLine(overloadParent.Addition(4, 5,9,6));
            //Console.ReadLine();
            OverrideClass1 overrideClass = new OverrideClass1();
            age age = new age();
            DOB dOB = new DOB();
            overrideClass.uday();
            age.uday();
            dOB.uday();
            Console.ReadLine();


        }
    }
}
