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
            ChildClass childClass = new ChildClass();
            childClass.ShowName();
            childClass.DisplayAge();
            childClass.Example();
            Console.ReadLine();
        }
    }
}
