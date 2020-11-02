using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Normalcalculator;

namespace CallDLLeg
{
    class Employeeeg
    {
        static void Main()
        {
            Clalculator calculator = new Clalculator();
            Console.WriteLine("addition of two numbers",calculator.Addition(25,65));
            Console.Read();
        }
    }
}
