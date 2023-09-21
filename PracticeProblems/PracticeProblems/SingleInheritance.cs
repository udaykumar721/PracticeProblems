using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SingleInheritance
    {
        private string Triangle = "triangle";
        public string Circle = "circle";
        public string Square = "square";
        public void Getshape()
        {
            Console.WriteLine("Shape Class");
        }
    }
    class Measurments : SingleInheritance
    {
        public string Height = "height";
        public string Width = "width";
        public void GetMeasurment()
        {
            Console.WriteLine("Circle" + Circle);
            Console.WriteLine("Measurment Class");
        }
    }

}
