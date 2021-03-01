using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("4946", "ALIF", 2.8F);
            Student s2 = new Student("5923", "ALFI", 3.5F);
            Student s3 = new Student("498565", "ROZA", 3.1F);

            Department d1 = new Department("CS", "COMPUTER SCIENCE");
            Department d2 = new Department("EEE", "ELECTRICAL AND ELECTRONIXS ENGINEERING");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d2;

            s1.ShowInfo();
            s1.ShowDepartment();

            s2.ShowInfo();
            s2.ShowDepartment();

            s3.ShowInfo();
            s3.ShowDepartment();

            d1.Name = "COMPUTER SCIENCE AND ENGINEERING";

            s1.ShowInfo();
            s1.ShowDepartment();

            d1.AddStudent(s1);
            d1.AddStudent(s2);

            
            
            d1.PrintStudent();
        }
    }
}
