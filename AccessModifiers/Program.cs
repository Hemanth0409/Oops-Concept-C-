using Oops_Concept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public  class Program:AccessModifiersTest
    {
        static void Main(string[] args)
        {
            Program program = new Program();
         
            Console.WriteLine(program.value1);
            Console.WriteLine(program.value);
        }
    }
}
