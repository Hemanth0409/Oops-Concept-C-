

using System;

namespace Oops_Concept
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            ChildrenData child = new ChildrenData(new Children() { FirstName = "Hemanth", LastName = "B", Age = 21, Dob = "09/04/2002" });
            child.PersonInfo();
            ChildrenData student = new StudentData(new Student() { FirstName="Hemanth",LastName="B", Age = 21, Dob = "09/04/2002",PassOutYear12th=2019,PassOutYear10th= 2017,Year=2022,College="SriKrishna College",Department= "It" });
            student.PersonInfo();
            ChildrenData employee = new EmployeeData(new Employee()  { FirstName = "Hemanth", LastName = "B", Age = 21, Dob = "09/04/2002" , PassOutYear12th = 2019, PassOutYear10th = 2017, College = "SriKrishna College", Department = "It",Degree= "BSC-It", Designation="Developer", Company="CG_VAk",Position= "Trainee",DegreePassOutYear= 2023 });
            employee.PersonInfo();
        }
    }

    public class ChildrenData
    {
        private Children _children { get; set; }
        public ChildrenData(Children children)
        {
            _children = children;
        }

        public virtual void PersonInfo()
        {
            Console.WriteLine($"Children Details: FirstName:{_children.FirstName},LastName:{_children.LastName},Age:{_children.Age},Date of Birth{_children.Dob}");
            Console.WriteLine();
        }
    }
    public class StudentData : ChildrenData
    {
        private Student _studentObj { get; set; }
        public StudentData(Student studentObj) : base(studentObj)
        {
            _studentObj = studentObj;
        }
        public override void PersonInfo()
        {
            Console.WriteLine($"Student Details: FirstName:{_studentObj.FirstName},LastName:{_studentObj.LastName},Age:{_studentObj.Age},Date of Birth:{_studentObj.Dob},Department:{_studentObj.Department},College:{_studentObj.College},Year:{_studentObj.Year},PassOutYear10th:{_studentObj.PassOutYear10th},PassOutYear12th:{_studentObj.PassOutYear12th}");
            Console.WriteLine();

        }
    }
    public class EmployeeData : StudentData
    {
        public int DegreePassOutYear;
        public string Degree;
        public string Designation;
        public string Company;
        public string Position;
        private Employee _employeeObj { get; set; }
        public EmployeeData(Employee employeeObj) : base(employeeObj)
        {
            _employeeObj = employeeObj;
        }
        public override void PersonInfo()
        {
            Console.WriteLine($"Employee Details: FirstName:{_employeeObj.FirstName},LastName:{_employeeObj.LastName},Age:{_employeeObj.Age},Date of Birth{_employeeObj.Dob},PassOutYear10th:{_employeeObj.PassOutYear10th},PassOutYear12th:{_employeeObj.PassOutYear12th},DegreePassOutYear:{_employeeObj.DegreePassOutYear},Degree:{_employeeObj.Degree},Designation:{_employeeObj.Designation},Position:{_employeeObj.Position},Company:{_employeeObj.Company}");
            Console.WriteLine();

        }
    }

    public class Children
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Dob { get; set; }

    }

    public class Student : Children
    {
        public string Department { get; set; }
        public string College { get; set; }
        public int Year { get; set; }
        public int PassOutYear10th { get; set; }
        public int PassOutYear12th { get; set; }

    }

    public class Employee : Student
    {
        public int DegreePassOutYear { get; set; }
        public string Degree { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }

    }
}
