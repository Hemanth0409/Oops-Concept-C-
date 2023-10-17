//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Concept
//{
//    public class InheritanceTask
//    {
//        public string firstName;
//        public string lastName;
//        public int age;
//        protected string dob;

//        public void Children(string firstName, string lastName, int age, string dob)
//        {
//            Console.WriteLine($"Children Details: FirstName:{firstName},LastName:{lastName},Age:{age},Date of Birth{dob}");
//            Console.WriteLine();

//        }
//    }
//    public class Student : InheritanceTask
//    {

//        public string department;
//        public string college;
//        public int year;
//        public int passYear10th;
//        public int passYear12th;

//        public void Studying(string department, string college, int year)
//        {
//            Console.WriteLine($"Department:{department},college:{college},Year:{year}");
//            Console.WriteLine();
//        }
//        public void StudentDetails(int passYear10th, int passYear12th)
//        {
//            Children(firstName, lastName, age, dob);
//            Studying(department, college, year);
//            Console.WriteLine($"STUDENT DETAILS : FirstName:{firstName},LastName:{lastName},Age:{age},Date of Birth{dob},Department{department},college{college},Year{year},10th Pass out Year:{passYear10th},12th Pass out Year:{passYear12th}");
//            Console.WriteLine();

//        }
//    }
//    public class Employee : Student
//    {
//        public int degreePassOutYear;
//        public string degree;
//        public string designation;
//        public string company;
//        public string position;

//        public void EmployeeDetails(string firstName, string lastName, int age, string dob,int passYear10th, int passYear12th,int degreePassOutYear, string degree, string designation, string company, string position)
//        {
//            Children(firstName, lastName, age, dob);
//            StudentDetails(passYear10th,passYear12th);
//            Console.WriteLine($"Employee Details : FirstName:{firstName},LastName:{lastName},Age:{age},Date of Birth{dob},10th Pass out Year:{passYear10th},12th Pass out Year:{passYear12th},DegreePassOutYear:{degreePassOutYear},Degree:{degree},Designation{designation},Company{company},Position{position}");
//            Console.WriteLine();

//        }
//    }
//    public class  Person:Employee
//    {
//        static void Main(string[] args)
//        {
//            Person data=new Person();
//            data.Children("Hemanth","B",21,"04/09/2002");
//            data.Studying("It","SriKrishna College",2022);
//            data.StudentDetails(2015, 2017);
//            data.EmployeeDetails("Hemanth", "B", 21, "04/09/2002",2015, 2017,2023, "BSC-IT","Developer","CG_VAK","Trainee");
//        }
//    }
//}
