using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //Class
    public class Data
    {
        //Access Modifires
        public int Id;
        public string Name;
        protected string gender;
        //Constructor
        public Data()
        {
            Id = 1;
            Name = "Sharon";
        }
    }
    public class Program : Data
    {
        private int age;
        //Encapsulation
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        static void Main(string[] args)
        {
            //Onject
            Program instance = new Program();
            instance.age = 5;
            instance.gender = "Male";
            Console.WriteLine("Id :" + instance.Id);
            Console.WriteLine("Name :" + instance.Name);
            Console.WriteLine("Age :" + instance.age);
            Console.WriteLine("Gender :" + instance.gender);
            Console.ReadLine();
        }
    }
}
