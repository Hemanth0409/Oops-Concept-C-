using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class AccessModifiersTest
    {
        protected internal int value = 0;
        protected int value1 = 12;
        private protected int value2 = 10;

    }
    public class AccessModifiersMain:AccessModifiersTest
    {  
      
        static void Main(string[] args)
        {
            AccessModifiersMain access=new AccessModifiersMain();
            Console.WriteLine(access.value2);    
            Console.WriteLine(access.value1);
        }
    }
    public class demo
    {
        static void Main(string[] args)
        {
            AccessModifiersTest de =new AccessModifiersTest();
            Console.WriteLine(de.value);
        }
    }
}
