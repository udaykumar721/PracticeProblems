using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class EncapsulationClass
    {
        int AccountBalance = 1000;
        public void SetBalance(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You Can not Pass Negative Value");
            }
            AccountBalance = amount;
        }
        public void GetBalance() 
        {
            Console.WriteLine("Your Account Balance Is :" + AccountBalance);
        }
    }
}
