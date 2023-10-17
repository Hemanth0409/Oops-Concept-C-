using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    //Abstraction

    public abstract class Abstraction
    {
        public int Id;
        public string Name;

        public Abstraction(int UserId, string UserName)
        {
            UserId = Id;
            UserName = Name;
        }

        public abstract void employee();
    }
    public sealed class SealedClass
    {
        public void employee()
        {

        }
    }

    public class EmployeeDetails : Abstraction
    {
        public int age;
        public EmployeeDetails(int UserId, string UserName, int age) : base(UserId, UserName)
        {
            this.age = age;
            Id = UserId;
            Name = UserName;
        }
        //Polymorphism
        public override void employee()
        {
            Console.WriteLine($"UserId:{Id} ,UserName:{Name},Age:{age}");
        }
        static void Main(string[] args)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails(101, "Sharon", 21);
            employeeDetails.employee();
        }
    }
}
