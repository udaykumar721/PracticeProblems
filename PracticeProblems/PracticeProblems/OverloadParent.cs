﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class OverloadParent
    {
        public int Addition(int a, int b)
        {
            return a + b ;
        }
        public int Addition(int a, int b,int c)
        {
            return a + b + c;
        }
        public int Addition(int a, int b,int c,int d)
        {
            return a + b + c + d;
        }
    }
}
