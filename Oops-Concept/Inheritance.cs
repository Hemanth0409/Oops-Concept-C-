using System;

namespace Oops_Concept
{
    public class PersonData
    {
        public string FirstName;
        public string LastName;
        public int Age;
        private string Dob;
        public string dob { get { return Dob; } set { Dob = value; } }
        public PersonData(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public virtual void PersonInfo()
        {
            Console.WriteLine($"Children Details: FirstName:{FirstName},LastName:{LastName},Age:{Age},Date of Birth{dob}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            PersonData child = new PersonData("Hemanth", "B", 21);
            child.dob = "09/04/2002";
            child.PersonInfo();
            PersonData student = new StudentData("Hemanth", "B", 21,"09/04", 2019, 2017, 2022, "SriKrishna College", "It");
            student.PersonInfo();
            PersonData employee = new EmployeeData("Hemanth", "B", 21, "04/09/2002", 2019, 2017, 2022, "SriKrishna College", "It", "BSC-It", "Developer", "CG_VAk", "Trainee", 2023);
            employee.PersonInfo();
        }
    }

    public class StudentData : PersonData
    {

        public string Department;
        public string College;
        public int Year;
        public int PassOutYear10th;
        public int PassOutYear12th;

        public StudentData(string firstName, string lastName, int age, string dob, int passOutYear12th, int passOutYear10th, int year, string college, string department) : base(firstName, lastName, age)
        {
            PassOutYear10th = passOutYear10th;
            PassOutYear12th = passOutYear12th;
            Year = year;
            College = college;
            Department = department;
        }
        public override void PersonInfo()
        {
            Console.WriteLine($"Student Details: FirstName:{FirstName},LastName:{LastName},Age:{Age},Date of Birth:{dob},Department:{Department},College:{College},Year:{Year},PassOutYear10th:{PassOutYear10th},PassOutYear12th:{PassOutYear12th}");
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

        public EmployeeData(string firstName, string lastName, int age, string dob, int passOutYear12th, int passOutYear10th, int year, string college, string department, string degree, string designation, string company, string position, int degreePassOutYear) : base(firstName, lastName, age, dob, passOutYear12th, passOutYear10th, year, college, department)
        {
            Degree = degree;
            Designation = designation;
            Company = company;
            Position = position;
            DegreePassOutYear = degreePassOutYear;
        }
        public override void PersonInfo()
        {
            Console.WriteLine($"Employee Details: FirstName:{FirstName},LastName:{LastName},Age:{Age},Date of Birth{dob},PassOutYear10th:{PassOutYear10th}," +
                $"PassOutYear12th:{PassOutYear12th},DegreePassOutYear:{DegreePassOutYear},Degree:{Degree},Designation:{Designation},Position:{Position},Company:{Company}");
            Console.WriteLine();

        }
    }
}
