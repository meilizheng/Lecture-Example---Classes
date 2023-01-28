using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public double cSIGrade;
        public double genEdGrade;        

        public Student(string firstName, string lastName, double cSIGrade, double genEdGrade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            CSIGrade = cSIGrade;
            GenEdGrade = genEdGrade;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double CSIGrade { get => cSIGrade; set => cSIGrade = value; }
        public double GenEdGrade { get => genEdGrade; set => genEdGrade = value; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            CSIGrade = -1;
            GenEdGrade = -1;
        }


    }
   
}
