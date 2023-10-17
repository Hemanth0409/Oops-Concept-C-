using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public abstract class LogBase
    {
        protected string Error;
        protected string Information;
        protected string DebugInformation;
        public abstract void logBase(string message);
    }

    public  class File :LogBase
    {
        public override void logBase(string message)
        {
            Console.WriteLine("File Logger");
        }
    }
    public class DBLogger : LogBase
    {
        public override void logBase(string message)
        {
            Console.WriteLine("DataBase Logger");
        }
    }
    public class Event : LogBase
    {
        public override void logBase(string message)
        {
            Console.WriteLine("Event Logger");
        }
    }

}
