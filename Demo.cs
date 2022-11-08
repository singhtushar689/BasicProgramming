using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NewProject
{
    internal class Demo
    {
        public int a;
        public int b;  
        public void Function()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subtraction of two number is :" + (a - b) );
        }
    }
   
}
