using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }     //  Employee class member

        public override void SayName()  //  Called the method SayName
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);   //  Prints
        }

        public void Quit(Employee employee)  // Calling the Quit method
        {
            Console.WriteLine("This method of interface is implemented on employee object for the student with the ID number " + ID + ".");
            Console.ReadLine();

        }
        }
    }
