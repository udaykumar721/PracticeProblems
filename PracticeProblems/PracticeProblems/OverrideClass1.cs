using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class OverrideClass1
    {
        public virtual void uday()
        {
            Console.WriteLine("Name is uday");
        }
    }
    class age : OverrideClass1
    {
        public override void uday()
        {
            Console.WriteLine("My Age is 22 Years");
        }
    }
    class DOB : OverrideClass1
    {
        public override void uday()
        {
            Console.WriteLine("My DOB is 27-06-2002");
        }
    }
}
