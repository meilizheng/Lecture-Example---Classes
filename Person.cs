using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes
{
    public class Person
    {
        public string lastName;
        public string firstName;
        public string address;
        public string emailID;
        public string emailAddress;

        public Person (string firstName, string lastName, string address)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Address = address;
        }
        public Person(string emailID, string emailAddress)
        {
            this.emailID = emailID;
            this.emailAddress = emailAddress;            
        }


        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Address { get => address; set => address = value; }
    }
}
