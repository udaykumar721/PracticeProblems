using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal abstract class  AbstractClass
    { 
        public void Person()
        {
            Console.WriteLine("It Will Work");
        }
        public abstract void work();
    }
    class Student : AbstractClass
    {
        public override void work()
        {
            Console.WriteLine("It Will Study");
        }
    }

}
